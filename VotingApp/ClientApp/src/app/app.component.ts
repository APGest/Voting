import { Component } from "@angular/core";
import { voterServices } from "./services/voter-services";
import { Voter } from "./models/Voter";
import { candidateServices } from "./services/candidate-services";
import { Candidate } from "./models/Candidate";
import { voterCandidate } from "./models/voterCandidate"
import { voterCandidateServices} from './services/voterCandidate-services'

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
})
export class AppComponent {
  title = "app";

  constructor(private _voterServices: voterServices, private _candidateServices: candidateServices) {

   }
  voters: Voter[];
  candidates: Candidate[];

  
 public add() : void {
  console.log("dziala");
}
  ngOnInit() {
    this._voterServices.getVoters().subscribe((result) => {
      this.voters = result;
    });
    this._candidateServices.getCandidates().subscribe((result) => {
      this.candidates = result;
    });
    
  }
}
