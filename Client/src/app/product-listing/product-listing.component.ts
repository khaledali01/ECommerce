import { Component, OnInit } from '@angular/core';
import { ApiService } from '../services/api.service';
import { Product } from '../models/Product';
import { Router } from '@angular/router';

@Component({
  selector: 'app-product-listing',
  templateUrl: './product-listing.component.html',
  styleUrls: ['./product-listing.component.css'],
})
export class ProductListingComponent implements OnInit {
  products: Product[] = [];

  constructor(private api: ApiService, private route: Router) {}
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

  NavigateToProductPage(id: number) {
    this.route.navigate([id]);
  }
}
