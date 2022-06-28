import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { CreateItemComponent } from './components/create-item/create-item.component';
import { ListItemsComponent } from './components/list-items/list-items.component';

const routes: Routes = [
  {
    path: '',
    component: ListItemsComponent,
  },
  {
    path: 'create-product',
    component: CreateItemComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
