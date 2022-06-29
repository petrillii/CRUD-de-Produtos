import { Component, OnInit } from '@angular/core';
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
      products.forEach((product: ProductModel)=>{
        product.principal_img = "<img src="+"data:image/png;base64,"+ product.principal_img + "alt="+"item"+"/>";
        product.secundary_img = "<img src="+"data:image/png;base64,"+ product.secundary_img + "alt="+"item"+"/>";
      })
      this.products = products;
    });
  }

}
