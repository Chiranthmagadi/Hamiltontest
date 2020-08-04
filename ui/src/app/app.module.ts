import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { AddressBookComponent } from './addressBook/addressBook.component';
import { AddressBookDetailComponent } from './addressBook-detail/addressBook-detail.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AddressBookComponent,
    AddressBookDetailComponent
  ],
  imports: [
    FormsModule,
    BrowserModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
