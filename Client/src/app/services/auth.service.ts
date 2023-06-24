import { Injectable } from '@angular/core';
import { RegisterDTO } from '../models/DTO/RegisterDTO';
import { HttpClient } from '@angular/common/http';
import { LoginDTO } from '../models/DTO/LoginDTO';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  constructor(private http: HttpClient) {}
  Register(registerDto: RegisterDTO) {
    this.http.post<RegisterDTO>('api/user/register', registerDto).subscribe(
      (data) => {
        console.log(data);
      },
      (err) => console.log(err)
    );
  }
  Login(loginDTO: LoginDTO) {
    this.http.post<LoginDTO>('/api/user/login', loginDTO).subscribe(
      (data) => {
        console.log(data);
      },
      (err) => console.log(err)
    );
  }
}
