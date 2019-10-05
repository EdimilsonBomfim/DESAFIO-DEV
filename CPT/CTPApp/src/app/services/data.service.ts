import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Produto } from '../models/produto.model';

@Injectable({
    providedIn: 'root'
})

export class DataService {

    public url = 'http://localhost:50088/api';

    constructor(private http: HttpClient) { }

    // Produtos
    getAllProducts() {
        return this.http.get<Produto[]>(`${this.url}/produto`);
    }    
}