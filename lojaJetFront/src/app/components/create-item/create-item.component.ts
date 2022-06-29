import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-create-item',
  templateUrl: './create-item.component.html',
  styleUrls: ['./create-item.component.scss']
})
export class CreateItemComponent implements OnInit {
  @ViewChild('divBanner') divBannerElement!: ElementRef;
  @ViewChild('inputFile') inputElement!: ElementRef;
  @ViewChild('divBannerSecundary') divSecundaryBannerElement!: ElementRef;
  @ViewChild('inputSecundaryFile') inputSecundaryElement!: ElementRef;
  principal_img!: File;
  secundary_img!: File;
  invalidImage: boolean = true;
  invalidPImage: boolean = true;
  form: FormGroup = this.getForm();
  constructor(
    private router: Router,
    private srvc: ProductService
  ) { }

  ngOnInit(): void {
  }

  getForm(): FormGroup{
    return new FormGroup({
      status: new FormControl(false, [Validators.required]),
      nm_product: new FormControl('', [Validators.required]),
      inventory: new FormControl('', [Validators.required]),
      price: new FormControl('',[Validators.required]),
      promotional_price: new FormControl('', [Validators.required]),
      ds_product: new FormControl('', [Validators.required]),
      principal_img: new FormControl(this.principal_img, [Validators.required]),
      secundary_img: new FormControl(this.secundary_img, [Validators.required]),
    })
  }

  onFilePrincipalChange(event: any){
    var reader = new FileReader();
    reader.readAsDataURL(event.target.files[0]);

    reader.onload = (eventReader: any) => {
      var image = new Image();

      image.src = eventReader.target.result;
      image.onload = (e: any) => {
        const { width, height } = e.path[0];

        if (width >= 1000  && height >= 1000) {
          this.invalidImage = false;
          this.principal_img = event.target.files[0];
          this.divBannerElement.nativeElement.style.setProperty(
            'background-image',
            `url("${eventReader.target.result}")`
          );
        } else {
          this.invalidImage = true;
          this.clearImage();
          console.log('img invalida')
        }
      };
    };
  }

  clearImage(): void {
    if (this.inputElement?.nativeElement)
      this.inputElement.nativeElement.value = '';
    if (this.divBannerElement?.nativeElement)
      this.divBannerElement?.nativeElement?.style.removeProperty(
        'background-image'
      );
  }

  clearSecundaryImage(): void {
    if (this.inputSecundaryElement?.nativeElement)
      this.inputSecundaryElement.nativeElement.value = '';
    if (this.divSecundaryBannerElement?.nativeElement)
      this.divSecundaryBannerElement?.nativeElement?.style.removeProperty(
        'background-image'
      );
  }

  onFileSecundaryChange(event: any){
    var reader = new FileReader();
    reader.readAsDataURL(event.target.files[0]);

    reader.onload = (eventReader: any) => {
      var image = new Image();

      image.src = eventReader.target.result;
      image.onload = (e: any) => {
        const { width, height } = e.path[0];

        if (width >= 1000  && height >= 1000) {
          this.invalidPImage = false;
          this.secundary_img = event.target.files[0];
          this.divSecundaryBannerElement.nativeElement.style.setProperty(
            'background-image',
            `url("${eventReader.target.result}")`
          );
        } else {
          this.invalidPImage = true;
          this.clearSecundaryImage();
          console.log('img invalida')
        }
      };
    };
  }

  onSubmit() {
    let formData = new FormData();
    let form = this.form.getRawValue();
    console.log(form)
    formData.append('nm_product', form.name);
    formData.append('principal_img', form.principal_img);
    formData.append('secundary_img', form.secundary_img);
    formData.append('ds_product', form.description);
    formData.append('inventory', form.inventory);
    formData.append('status', form.status);
    formData.append('price', form.price);
    formData.append('promotional_price', form.promotional_price);
    console.log(formData);
    this.srvc.InsertProduct(formData).subscribe(res=>{

    })
  }

  cancel(){
    this.router.navigate(['/']);
  }
}
