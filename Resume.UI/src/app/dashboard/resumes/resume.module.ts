import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { RouterModule } from '@angular/router';

import { DashboardResumesComponent } from './resumes.component';
import { SectionsDashboardModule } from '../sections/sections.module';

@NgModule({
    imports: [
        CommonModule,
        BrowserModule,
        FormsModule,
        RouterModule,
        SectionsDashboardModule,
        NgbModule
    ],
    declarations: [ DashboardResumesComponent ],
    exports:[ DashboardResumesComponent ],
    providers: []
})
export class ResumeModule { }
