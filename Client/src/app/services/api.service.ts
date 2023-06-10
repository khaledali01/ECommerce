import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IProduct } from '../models/IProduct';

@Injectable({
  providedIn: 'root'
})
export class ApiService {


  constructor(private http: HttpClient) { }

  getProducts() {
    return this.http.get<IProduct[]>("/api/products");
  }

}
