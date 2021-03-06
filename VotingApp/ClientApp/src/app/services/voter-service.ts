import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
@Injectable()
export class voterServices {
    constructor(private httpclient: HttpClient) { }
    getVoters(): Observable<any> {
        return this.httpclient.get('https://localhost:5001/api/voter/getall');
    }
}
