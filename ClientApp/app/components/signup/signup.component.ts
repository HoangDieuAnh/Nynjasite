import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'signup',
    templateUrl: './signup.component.html'
})
export class SignUpComponent {
    public forecasts: WeatherForecast[];

    constructor(http: Http) {
        http.get('/api/SampleData/WeatherForecasts').subscribe(result => {
            this.forecasts = result.json() as WeatherForecast[];
        });
    }
}

interface WeatherForecast {
    dateFormatted: string;
    temperatureC: number;
    temperatureF: number;
    summary: string;
}
