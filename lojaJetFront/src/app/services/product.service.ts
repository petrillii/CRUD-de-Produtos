import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  url: string = environment.linkApi + '/Product';
  constructor(
    private http: HttpClient
  ) { }

  InsertProduct(product: FormData):Observable<any>{
    return this.http.post(this.url, product);
  }

  GetProducts(){
    return this.http.get(this.url);
  }

  GetProductById(id: number){
    return this.http.get(this.url+'/'+id);
  }

}
