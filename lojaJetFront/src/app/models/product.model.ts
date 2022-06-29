export class ProductModel{
  constructor() {
    this.nm_product = 'nome',
    this.ds_product = 'descrição',
    this.inventory = 0,
    this.status = true,
    this.price = 0,
    this.promocional_price = 0
  }
  id_product!: number;
  nm_product: string;
  principal_img: any;
  secundary_img: any;
  ds_product: string;
  inventory: number;
  status: boolean;
  price: number;
  promocional_price: number;
}
