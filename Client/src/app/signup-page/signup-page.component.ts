import { Component } from '@angular/core';
import { RegisterDTO } from '../models/DTO/RegisterDTO';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-signup-page',
  templateUrl: './signup-page.component.html',
  styleUrls: ['./signup-page.component.css'],
})
export class SignupPageComponent {
  constructor(private authService: AuthService) {
    
  }

  Register(
    firstname: string,
    lastname: string,
    username: string,
    email: string,
    password: string,
    confirmedPassword: string
  ) {
    // Populating RegisterDTO with User Input
    let registerDto = new RegisterDTO();
    registerDto.FirstName = firstname;
    registerDto.LastName = lastname;
    registerDto.UserName = username;
    registerDto.Email = email;
    registerDto.Password = password;

    // Input Data Validation
    try {
      if (
        registerDto.FirstName != '' &&
        registerDto.LastName != '' &&
        registerDto.UserName != '' &&
        registerDto.Email != '' &&
        registerDto.Password != '' &&
        confirmedPassword == registerDto.Password
      ) {
        this.authService.Register(registerDto);
      }
    } catch (error) {
      console.log(error);
    }
  }
}
