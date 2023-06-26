import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject } from 'rxjs';
import { Cart, ICart } from '../models/ICart';
import { CartProduct } from '../models/CartProduct';

@Injectable({
  providedIn: 'root',
})
export class CartService {
  private cart: Cart = new Cart();
  private cartSource = new BehaviorSubject<ICart>(this.cart);
  cart$ = this.cartSource.asObservable();
  constructor(private http: HttpClient) {}

  postCartProduct(product: any, quantity = 1) {
    const userCart = this.getCurrentCartValue() ?? this.cart;
    userCart.products = this.addOrUpdateProduct(
      userCart.products,
      product,
      quantity
    );
    console.log(userCart);
    this.setCart(userCart);
  }
  getCurrentCartValue() {
    return this.cartSource.value;
  }

  setCart(userCart: ICart) {
    return this.http.post('api/cart', userCart).subscribe((response: any) => {
      console.log(response);
      this.cartSource.next(response);
    });
  }

  addOrUpdateProduct(
    products: CartProduct[],
    productToAdd: CartProduct,
    quantity: number
  ): any {
    const productIndex = products.findIndex((i) => i.id === productToAdd.id);
    if (productIndex === -1) {
      productToAdd.quantity = quantity;
      products.push(productToAdd);
    } else {
      products[productIndex].quantity += quantity;
    }
    return products;
  }
}
