import { HttpClient } from '@angular/common/http';
import { Input, Component, Output, EventEmitter } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

interface Country {
  id: number;
  name: string;
}

interface Province {
  id: number;
  countryId: number;
  name: string;
}

interface User {
  login: string,
  password: string,
  agreeWorkForFood: boolean,
  countryId: number;
  provinceId: number;
}

@Component({
  selector: 'wizard-step2-form',
  templateUrl: './wizard-step2-form.component.html',
  styleUrl: './wizard-step2-form.component.css'
})

export class WizardStep2Component {
  form: FormGroup = new FormGroup({
    country: new FormControl('', [Validators.required]),
    province: new FormControl('', [Validators.required])
  });

  userModel: User = {
    login: '',
    password: '',
    agreeWorkForFood: false,
    countryId: 0,
    provinceId: 0
  };

  public countries: Country[] = [];
  public provinces: Province[] = [];
  public selectedCountryId: number = 0;

  constructor(private http: HttpClient) { }

  baseUrl: string = 'https://localhost:7211';

  ngOnInit() {
    this.getCountries();
  }
  submit() {
    if (this.form.valid) {
      console.log(this.userModel);
      this.addUser(this.userModel);
      this.submitEM.emit(this.form.value);
    }
  }

  getCountries() {
    this.http.get<Country[]>(`${this.baseUrl}/country`).subscribe(
      (result) => {
        this.countries = result;
      },
      (error) => {
        console.error(error);
      }
    );
  }

  getProvinceByCountryId(countryId: number) {
    this.http.get<Province[]>(`${this.baseUrl}/province?countryId=${countryId}`).subscribe(
      (result) => {
        this.provinces = result;
      },
      (error) => {
        console.error(error);
      }
    );
  }

  addUser(userModel: User) {

    // Test data for creating user
    var userModel = <User>{
      login: 'shushkov@gmail.com',
      password: 'password1',
      agreeWorkForFood: true,
      countryId: 1,
      provinceId: 2
    };

    this.http.post(`${this.baseUrl}/user`, userModel).subscribe(
      (result) => {
      },
      (error) => {
        console.error(error);
      }
    );
  }

  changeValue(value: any) {
    this.selectedCountryId = value;
    this.getProvinceByCountryId(this.selectedCountryId);
  }

  @Input() error: string | null | undefined;

  @Output() submitEM = new EventEmitter();

}
