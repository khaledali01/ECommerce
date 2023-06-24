import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-product-page',
  templateUrl: './product-page.component.html',
  styleUrls: ['./product-page.component.css'],
})
export class ProductPageComponent implements OnInit {
  id: number = 1;
  data: any;

  constructor(private apiService: ApiService, private route: ActivatedRoute) {}

  ngOnInit(): void {
    this.route.params.subscribe((params) => {
      this.id = Number(params['id']);
    });
    this.apiService.getProduct(this.id).subscribe(
      (data) => {
        this.data = data;
        console.log(data);
      },
      (err) => console.log(err)
    );
  }
}
