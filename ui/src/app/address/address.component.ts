import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { AddressBookService } from '../services/address.service';
import { Observable, of } from 'rxjs';
import { AddressBookModel } from '../models/address.model';
@Component({
  selector: 'app-address',
  templateUrl: './address.component.html',
  styleUrls: ['./address.component.scss']
})
export class AddressComponent implements OnInit {

  public addresses: Observable<AddressBook[]>;
  public types:any[]=[];

  public newCustomer: CustomerModel = {
    AddressId: null,
    FirstNname: null,
	surNname: null,
    DateOFBirth: null
	Email:null
  };

  constructor(
    public addressService: AddressService) {
    }

  ngOnInit() {
    this.addresses =this.addressService.GetAddresses();
    this.types=["Large","Small"];
  }

  public createAddress(form: NgForm): void {
    if (form.invalid) {
      alert('form is not valid');
    } else {
      this.addressService.CreateAddress(this.newAddress).then(() => {
       this.addressService.GetAddresses().subscribe(Addresses => this.addresses = of(addresses));
      });
    }
  }

}
