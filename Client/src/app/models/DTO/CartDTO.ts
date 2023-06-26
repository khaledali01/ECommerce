import { Product } from "../Product";

export interface CartDTO {
    UserId: string;
    Products: Product[];
}