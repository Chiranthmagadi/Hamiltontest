import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { AddressBook } from '../models/addressBook.model';
import { shareReplay, share } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AddressBookService {

  constructor(private httpClient: HttpClient) { }

  public GetAdresses(): Observable<AddressBook[]> {
    return this.httpClient.get<AddressBook[]>('http://localhost:63235/addressBook').pipe(share());
  }

  public GetAdress(addressId: number): Observable<AddressBook> {
    return this.httpClient.get<AddressBook>(`http://localhost:63235/addressBook/${addressId}`).pipe(shareReplay());
  }

  public CreateAddress(addressBook: AddressBook): Promise<object> {
    return this.httpClient.post('http://localhost:63235/addressBook', addressBook).toPromise();
  }
}
