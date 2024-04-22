import { Input, Component, Output, EventEmitter } from '@angular/core';
import { FormGroup, FormControl, Validators, ValidationErrors } from '@angular/forms';
//import { Router } from '@angular/router';

@Component({
  selector: 'wizard-step1-form',
  templateUrl: './wizard-step1-form.component.html',
  styleUrl: './wizard-step1-form.component.css'

})
export class WizardStep1Component {
  form: FormGroup = new FormGroup({
    login: new FormControl('', [Validators.required, Validators.email]),
    password: new FormControl('', [Validators.required, Validators.pattern('[0-9]+[a-z]+')]),
    confirmPassword: new FormControl('', [Validators.required]),
    isWorkForFood: new FormControl('', [Validators.required])
  });

  //constructor(private router: Router) { }

  submit() {
    if (this.form.valid) {
      this.submitEM.emit(this.form.value);
      //this.router.navigate(['/step2']);
    }
  }

  @Input() error: string | null | undefined;

  @Output() submitEM = new EventEmitter();

}

export function passwordMatchValidator(formGroup: FormGroup): ValidationErrors | null {
    const parent = formGroup.parent as FormGroup;
    if (!parent) return null;
    return parent!.get('password')!.value === parent!.get('confirmPassword')!.value ?
        null : { 'mismatch': true };
}
