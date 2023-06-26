import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EventService {

  private subject2 = new Subject<any>();

  constructor() { }

  sendClickEventCounter() {
    console.log('click')
    this.subject2.next(this.getEventCounter());
  }

  getEventCounter() {
    return this.subject2.asObservable();
  }
}
