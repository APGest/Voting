import { Component } from "@angular/core";
import { voterServices } from "./services/voter-services";
import { Voter } from "./models/Voter";
import { candidateServices } from "./services/candidate-services";
import { Candidate } from "./models/Candidate";
import { voterCandidate } from "./models/voterCandidate"

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
})
export class AppComponent {
  title = "app";

  constructor(private _voterServices: voterServices, private _candidateServices: candidateServices, private _voterCandidateServices) { }
  voters: Voter[];
  candidates: Candidate[];
  voterCandidates: voterCandidate[];
  ngOnInit() {
    this._voterServices.getVoters().subscribe((result) => {
      this.voters = result;
    });
    this._candidateServices.getCandidates().subscribe((result) => {
      this.candidates = result;
    });
    this._voterCandidateServices.getvoterscandidates().subscribe((result) => {
      this.voterCandidates = result;
    });
  }
}
