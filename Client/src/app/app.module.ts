import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http'

import { AppComponent } from './app.component';
import { ProductListingComponent } from './product-listing/product-listing.component';
import { ProductPageComponent } from './product-listing/product-page/product-page.component';
import { ApiService } from './services/api.service';
import { RouterModule, Routes } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

const routes: Routes = [
  { path: "products", component: ProductListingComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    ProductListingComponent,
    ProductPageComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot(routes),
    BrowserAnimationsModule, 
  ],
  providers: [ApiService],
  bootstrap: [AppComponent]
})
export class AppModule { }
