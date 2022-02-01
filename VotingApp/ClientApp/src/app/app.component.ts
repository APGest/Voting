import { Component } from "@angular/core";
import { voterServices } from "./services/voter-services";
import { Voter } from "./models/voter";
@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
})
export class AppComponent {
  title = "app";

  constructor(private _voterServices: voterServices) {}
  voters : Voter[];
  ngOnInit() {
    this._voterServices.getVoters().subscribe((result) => {
      this.voters = result;
    });
  }
}
