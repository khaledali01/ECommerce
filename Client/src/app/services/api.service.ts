import { HttpClient } from '@angular/common/http';
import { Injectable, OnInit } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ApiService {


  constructor(private http: HttpClient) { }

  getProducts() {
    return this.http.get("/api/products").subscribe((response) => {
      console.log(response);
    }, (error) => {
      console.log(error)
    });
  }

}
