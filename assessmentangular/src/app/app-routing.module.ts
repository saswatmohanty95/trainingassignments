import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { CreateComponent } from './create/create.component';
import { DeplistComponent } from './deplist/deplist.component';


const routes: Routes = [
  {path:'',component:AppComponent},
  {path:'list',component:DeplistComponent},
  {path:'create',component:CreateComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
