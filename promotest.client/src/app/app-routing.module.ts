import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { WizardStep2Component } from './components/wizard-step2-form/wizard-step2-form.component';
import { WizardStep1Component } from './components/wizard-step1-form/wizard-step1-form.component';

const routes: Routes = [
  { path: '', redirectTo: '/step1', pathMatch: 'full' },
  { path: 'step1', component: WizardStep1Component },
  { path: 'step2', component: WizardStep2Component }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
