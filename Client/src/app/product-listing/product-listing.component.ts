import { Component, OnInit } from '@angular/core';
import { ApiService } from '../services/api.service';
import { IProduct } from '../models/IProduct';


@Component({
  selector: 'app-product-listing',
  templateUrl: './product-listing.component.html',
  styleUrls: ['./product-listing.component.scss']
})
export class ProductListingComponent implements OnInit {

  products: IProduct[] = [];

  constructor(private api: ApiService) { }
  ngOnInit(): void {
    this.getProducts();
  }
  getProducts() {
    this.api.getProducts().subscribe((response: IProduct[]) => {
      this.products = response
      console.log(this.products);
    }, (error) => {
      console.log(error);
    });
  }
}
