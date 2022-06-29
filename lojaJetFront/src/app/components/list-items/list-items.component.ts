import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import { ProductModel } from 'src/app/models/insertproduct.model';
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
    private sanitizer: DomSanitizer
  ) { }

  ngOnInit(): void {
    this.srvc.GetProducts().subscribe((products: any) => {
      console.log(products)
      products.forEach((product: ProductModel) => {
        product.principal_img = 'data:image/png;base64,'+product.principal_img;
        product.secundary_img = 'data:image/png;base64,'+product.secundary_img;

        /* const img_principal = new File([product.principal_img], 'image.jpeg', {
          type: product.principal_img.type,
        });
        product.principal_img = img_principal;
        const img_secundary = new File([product.secundary_img], 'image.jpeg', {
          type: product.secundary_img.type,
        });
        product.secundary_img = img_secundary; */
      })
      this.products = products;
    });
  }
}
