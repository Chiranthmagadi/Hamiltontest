import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AddressBookService } from '../services/addressBook.service';
import { AddressBook } from '../models/addressBook.model';

@Component({
  selector: 'app-addressBook-detail',
  templateUrl: './addressBook-detail.component.html',
  styleUrls: ['./addressBook-detail.component.scss']
})
export class AddressBookDetailComponent implements OnInit {

  private addressId: number;

  public addressBook: AddressBook;

  constructor(
    private route: ActivatedRoute,
    private addressBookervice: AddressBookervice) {
      this.addressId = route.snapshot.params.id;
    }

  ngOnInit() {
    this.addressBookervice.GetAddress(this.addressId).subscribe(address => this.address = address);
  }

}
