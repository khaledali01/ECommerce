import { Injectable } from '@angular/core';
import { RegisterDTO } from '../models/DTO/RegisterDTO';
import { HttpClient } from '@angular/common/http';
import { LoginDTO } from '../models/DTO/LoginDTO';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  IsLoggedIn: boolean = false;
  constructor(private http: HttpClient, private router: Router) {}
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
      (data: any) => {
        console.log(data);
        localStorage.setItem('Authorization', data.token)
        localStorage.setItem('UserId', data.userid)
        localStorage.setItem('username', data.username)
        localStorage.setItem('IsAdmin', data.isadmin)
        this.IsLoggedIn = true;
        this.router.navigate([''])
      },
      (err) => console.log(err)
    );
  }
  isLoggedIn() {
    return localStorage.getItem('Authorization') != null;
  }
  userId() {
    return localStorage.getItem('UserId')!;
  }

}
