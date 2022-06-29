import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { ProductModel } from '../models/insertproduct.model';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  constructor(
    private http: HttpClient
  ) { }

  InsertProduct(product: FormData):Observable<any>{
    let url = environment.linkApi + '/Product'
    return this.http.post(url, product);
  }

  GetProducts(){
    let url = environment.linkApi + '/Product'
    return this.http.get(url);
  }

}
