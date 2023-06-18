import { Component, OnInit } from '@angular/core';
import { ApiService } from '../services/api.service';
import { Product } from '../models/Product';

@Component({
  selector: 'app-product-listing',
  templateUrl: './product-listing.component.html',
  styleUrls: ['./product-listing.component.css'],
})
export class ProductListingComponent implements OnInit {
NavigateToDetailes(arg0: any) {
throw new Error('Method not implemented.');
}
  products: Product[] = [];

  constructor(private api: ApiService) {}
  ngOnInit(): void {
    this.getProducts();
  }
  getProducts() {
    this.api.getProducts().subscribe(
      (response: Product[]) => {
        this.products = response;
        console.log(this.products);
      },
      (error) => {
        console.log(error);
      }
    );
  }
}
