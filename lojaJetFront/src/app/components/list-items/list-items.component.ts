import { Component, OnInit } from '@angular/core';
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
    private srvc: ProductService
  ) { }

  ngOnInit(): void {
    this.srvc.GetProducts().subscribe((products: any) => {
      console.log(products)
      this.products = products;
    });
  }

}
