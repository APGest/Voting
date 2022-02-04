import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { HttpClient } from "@angular/common/http";

@Injectable()
export class CandidateServices  {
    constructor(private httpclient: HttpClient ) {}
 getCandidates(): Observable<any>{
     return this.httpclient.get('https://localhost:5001/api/candidate/getall');
 }
}
