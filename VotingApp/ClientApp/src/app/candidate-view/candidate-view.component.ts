import { Component, OnInit } from '@angular/core';
import { CandidateServices } from '../services/candidate-service';
import { CandidateModelSummary } from '../models/candidate-model-summary.model';
import { Candidate } from '../models/candidate';

@Component({
  selector: 'app-candidate-view',
  templateUrl: './candidate-view.component.html',
  styleUrls: ['./candidate-view.component.css']
})
export class CandidateViewComponent implements OnInit {

  constructor( private _candidateServices: CandidateServices) { }
  candidates: Candidate[];
  ngOnInit() {
    this._candidateServices.getCandidates().subscribe((result) => {
      this.candidates = result;
    });
  }
  

}
