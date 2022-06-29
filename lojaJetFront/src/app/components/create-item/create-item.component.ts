import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { UntypedFormControl, UntypedFormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
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
  img_principal!: File;
  img_secundary!: File;
  invalidImage: boolean = true;
  invalidPImage: boolean = true;
  form: UntypedFormGroup = this.getForm();
  constructor(
    private router: Router,
    private srvc: ProductService,
    private toastr: ToastrService
  ) { }

  ngOnInit(): void {
  }

  getForm(): UntypedFormGroup{
    return new UntypedFormGroup({
      status: new UntypedFormControl(false, [Validators.required]),
      nm_product: new UntypedFormControl('', [Validators.required]),
      inventory: new UntypedFormControl('', [Validators.required]),
      price: new UntypedFormControl('',[Validators.required]),
      promocional_price: new UntypedFormControl('', [Validators.required]),
      ds_product: new UntypedFormControl('', [Validators.required]),
      img_principal: new UntypedFormControl(this.img_principal, [Validators.required]),
      img_secundary: new UntypedFormControl(this.img_secundary, [Validators.required]),
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
          this.img_principal = event.target.files[0];
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
          this.img_secundary = event.target.files[0];
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
    formData.append('nm_product', form.nm_product);
    formData.append('img_principal', this.img_principal);
    formData.append('img_secundary', this.img_secundary);
    formData.append('ds_product', form.description);
    formData.append('inventory', form.inventory);
    formData.append('status', form.status);
    formData.append('price', form.price);
    formData.append('promocional_price', form.promocional_price);
    console.log(formData);
    this.srvc.InsertProduct(formData).subscribe({
      error: (error: any) => {
        console.log(error)
        this.toastr.error(error.message, 'Erro ao cadastrar o novo produto');
      },
      complete: () => {
        this.toastr.success('Produto cadastrado com sucesso!');
      },
      next: (res: string) => {
        this.toastr.success(res, 'Produto cadastrado com sucesso!');
      }
    })
  }

  cancel(){
    this.router.navigate(['/']);
  }
}
