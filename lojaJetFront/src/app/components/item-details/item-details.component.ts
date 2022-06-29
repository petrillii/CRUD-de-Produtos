import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ProductModel } from 'src/app/models/product.model';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-item-details',
  templateUrl: './item-details.component.html',
  styleUrls: ['./item-details.component.scss']
})
export class ItemDetailsComponent implements OnInit {
  idProduct!: number;
  /* product: ProductModel = new ProductModel(); */
  constructor(
    private srvc: ProductService,
    private route: ActivatedRoute
  ) { }

  ngOnInit(): void {
   /*  this.route.params.subscribe(params => {
      this.idProduct = params['id'];
      this.srvc.GetProductById(this.idProduct).subscribe((productInfo)=>{
        this.product = productInfo;
        console.log(productInfo)
      });
    }); */
  }

}
