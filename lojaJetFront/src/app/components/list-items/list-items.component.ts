import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import { Router } from '@angular/router';
import { ProductModel } from 'src/app/models/product.model';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-list-items',
  templateUrl: './list-items.component.html',
  styleUrls: ['./list-items.component.scss']
})
export class ListItemsComponent implements OnInit {
  products: ProductModel[] = [];
  constructor(
    private srvc: ProductService,
    private sanitizer: DomSanitizer,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.srvc.GetProducts().subscribe((products: any) => {
      console.log(products)
      products.forEach((product: ProductModel) => {
        product.principal_img = 'data:image/png;base64,'+product.principal_img;
        product.secundary_img = 'data:image/png;base64,'+product.secundary_img;
      })
      this.products = products.filter((s: { status: boolean; }) => s.status);
    });
  }

  detailsItem(id: number){
    this.router.navigate(['/product-details/'+ id]);
  }
}
