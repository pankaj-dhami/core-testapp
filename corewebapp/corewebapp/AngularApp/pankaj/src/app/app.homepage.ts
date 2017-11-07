import { Component } from '@angular/core'
import { Http } from '@angular/http'

@Component({

    selector:'app-home',
    templateUrl: './app.homepage.html',
    styleUrls: ['./app.component.css']


})
export class HomeComponent{

    Title:any = "Pankaj Angular";

    constructor() {
        this.Title = "Angular js";
        
    }
}