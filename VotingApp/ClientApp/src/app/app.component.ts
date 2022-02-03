import { Component } from "@angular/core";
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { voterServices } from "./services/voter-services";
import { Voter } from "./models/Voter";
import { candidateServices } from "./services/candidate-services";
import { Candidate } from "./models/Candidate";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
})
export class AppComponent {
  title = "app";

  constructor(private _voterServices: voterServices, private _candidateServices: candidateServices) {

  }
  candidateName: string;
  voterName: string;
  voters: Voter[];
  candidates: Candidate[];
  form = new FormGroup({
    candidate: new FormControl('', Validators.required),
    voter: new FormControl('', Validators.required),
  });
  get f() {
    return this.form.controls;
  }

  submit() {
    console.log(this.form.value);
  }
  AddVoters(voterName) {
    console.log("New Voter Name: " + voterName)
  }
  AddCandidate(candidateName){
    console.log("New Candidate Name: " + candidateName)
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
