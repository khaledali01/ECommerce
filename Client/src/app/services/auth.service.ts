import { Injectable } from '@angular/core';
import { RegisterDTO } from '../models/DTO/RegisterDTO';
import { HttpClient } from '@angular/common/http';

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
}
