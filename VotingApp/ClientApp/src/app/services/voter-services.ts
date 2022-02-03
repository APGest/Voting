import { Injectable, Inject } from "@angular/core";
import { Observable, fromEvent } from "rxjs";
import { HttpClient } from "@angular/common/http";
// import { Voter } from "../models/Voter";


@Injectable()
export class voterServices {
    constructor(private httpclient: HttpClient) { }
    getVoters(): Observable<any> {
        return this.httpclient.get('https://localhost:44308/api/voter/getall');

    }
}