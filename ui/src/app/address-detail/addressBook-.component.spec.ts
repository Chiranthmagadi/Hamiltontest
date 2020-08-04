import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdressBookDetailComponent } from './adressBook-detail.component';

describe('AdressBookDetailComponent', () => {
  let component: AdressBookDetailComponent;
  let fixture: ComponentFixture<AdressBookDetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdressBookDetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdressBookDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
