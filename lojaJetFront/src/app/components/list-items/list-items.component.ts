import { Component, OnInit } from '@angular/core';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-list-items',
  templateUrl: './list-items.component.html',
  styleUrls: ['./list-items.component.scss']
})
export class ListItemsComponent implements OnInit {
  products: any;
  constructor(
    private srvc: ProductService
  ) { }

  ngOnInit(): void {
    this.srvc.GetProducts().subscribe((products: any) => {
      this.products = products;
    });
  }

}
