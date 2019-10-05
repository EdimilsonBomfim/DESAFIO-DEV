import { Component, OnInit } from '@angular/core';
import { Produto } from 'src/app/models/produto.model';
import { DataService } from 'src/app/services/data.service';

@Component({
  selector: 'app-produto-page',
  templateUrl: './produto-page.component.html',
  styleUrls: ['./produto-page.component.css']
})
export class ProdutoPageComponent implements OnInit {
  public products: Produto[];

  constructor(private service: DataService) { }

  ngOnInit() {
    //this.getAllProducts();
  }

  getAllProducts() {
    this.service.getAllProducts().subscribe(
      (data: Produto[]) => {
        this.products = data;
        //console.log(this.products);
      },
      (error) => {
        console.log(error);
      }
    );
  }
  
}
