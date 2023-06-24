import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Product } from '../models/Product';

@Injectable({
  providedIn: 'root',
})
export class ApiService {
  constructor(private http: HttpClient) {}

  getProducts() {
    return this.http.get<Product[]>('/api/products');
  }

  getProduct(id: number) {
    return this.http.get('api/products/' + id);
  }
}
