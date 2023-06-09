import { Component, OnInit } from '@angular/core';
import { ApiService } from '../services/api.service';


@Component({
  selector: 'app-product-listing',
  templateUrl: './product-listing.component.html',
  styleUrls: ['./product-listing.component.css']
})
export class ProductListingComponent implements OnInit {

  constructor(private api: ApiService) { }
  ngOnInit(): void {
    this.getProducts();
  }
  getProducts() {
    return this.api.getProducts();
  }
}
