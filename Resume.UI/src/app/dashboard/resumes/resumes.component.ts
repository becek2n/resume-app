import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-resume-section',
  templateUrl: './resumes.component.html',
  styleUrls: ['./resumes.component.css']
})
export class DashboardResumesComponent implements OnInit {
  page = 2;
  page1 = 3;
  active = 1;
  active1 = 1;
  active2 = 1;

  constructor() { }

  ngOnInit() {
  }

}
