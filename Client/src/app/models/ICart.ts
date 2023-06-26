import { CartProduct } from "./CartProduct";
import {v4} from 'uuid'

export interface ICart {
  id: string;
  products: CartProduct[];
}

export class Cart implements ICart {
  id = v4();
  products: CartProduct[] = [];
}
