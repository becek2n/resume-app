import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DashboardResumesComponent } from './resumes.component';

describe('DashboardResumesComponent', () => {
  let component: DashboardResumesComponent;
  let fixture: ComponentFixture<DashboardResumesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DashboardResumesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DashboardResumesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
