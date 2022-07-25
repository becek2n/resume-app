import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule } from '@angular/forms';
import { NouisliderModule } from 'ng2-nouislider';
import { JwBootstrapSwitchNg2Module } from 'jw-bootstrap-switch-ng2';
import { RouterModule } from '@angular/router';

import { SectionsComponentDashboard } from './sections.component';
import { PersonalDetailComponent } from './personal-detail/personal-detail.component';

@NgModule({
  declarations: [
    SectionsComponentDashboard,
    PersonalDetailComponent
    
  ],
  // entryComponents: [NgbdModalContent],
  imports: [
    CommonModule,
    FormsModule,
    NgbModule,
    RouterModule,
    NouisliderModule,
    JwBootstrapSwitchNg2Module
  ],
  exports:[ SectionsComponentDashboard ]
})
export class SectionsDashboardModule { }
