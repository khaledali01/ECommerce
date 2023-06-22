import { Injectable } from '@angular/core';
import { RegisterDTO } from '../models/DTO/RegisterDTO';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http: HttpClient) { }
  Register(registerDto: RegisterDTO) {
    this.http.post("user/register", registerDto);
  }
}
