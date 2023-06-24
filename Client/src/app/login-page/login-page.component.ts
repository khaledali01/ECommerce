import { Component } from '@angular/core';
import { LoginDTO } from '../models/DTO/LoginDTO';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.css'],
})
export class LoginPageComponent {
  constructor(private authService: AuthService) {}

  Login(userName: string, password: string) {
    let loginDTO = new LoginDTO();
    loginDTO.UserName = userName;
    loginDTO.Password = password;
    this.authService.Login(loginDTO);
  }
}
