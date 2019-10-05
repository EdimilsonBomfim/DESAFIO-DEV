import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProdutoPageComponent } from './pages/produto-page/produto-page.component';

const routes: Routes = [
  {
    path: '',
    component: ProdutoPageComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
