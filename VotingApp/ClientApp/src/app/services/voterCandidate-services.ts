import { Injectable , Inject } from "@angular/core";
import { Observable } from "rxjs";
import { HttpClient } from "@angular/common/http";

@Injectable()
export class voterCandidateServices{
    constructor(private httpclient: HttpClient ) {}
 getVotersCandidates(): Observable<any>{
     return this.httpclient.get('https://localhost:44308/api/voterCandidate/getall');
 }
}