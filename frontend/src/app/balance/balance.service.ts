import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root' 
})
export class BalanceService {

  private readonly url = 'http://localhost:5175/api/client/balance';

  constructor(private http: HttpClient) {}

  getBalanceXml(): Observable<string> {
    return this.http.get(this.url, { responseType: 'text' });
  }
}

