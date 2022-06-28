import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { InsertProductModel } from '../models/insertproduct.model';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  constructor(
    private http: HttpClient
  ) { }

  InsertProduct(product: File):Observable<any>{
    let url = environment.linkApi + '/Product'
    const formData = new FormData();
    formData.append("product", product, product.name);
    return this.http.post(url, product);
  }

  GetProducts(){
    let url = environment.linkApi + '/Product'
    return this.http.get(url);
  }

}
