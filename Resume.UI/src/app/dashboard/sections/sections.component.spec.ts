import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SectionsComponentDashboard } from './sections.component';

describe('SectionsComponentDashboard', () => {
  let component: SectionsComponentDashboard;
  let fixture: ComponentFixture<SectionsComponentDashboard>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SectionsComponentDashboard ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SectionsComponentDashboard);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
