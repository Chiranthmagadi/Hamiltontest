import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { AddressBookComponent } from './addressBook/addressBook.component';
import { AddressBookDetailComponent } from './addressBook-detail/addressBook-detail.component';


const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'home', component: HomeComponent },
  { path: 'addressBook', component: AddressBookComponent },
  { path: 'addressBook/:id', component: AddressBookDetailComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
