import { Component } from '@angular/core'

@Component({

    selector:'app-home',
    templateUrl: './app.homepage.html',
    styleUrls: ['./app.component.css']


})
export class HomeComponent{

    Title:any = "Pankaj Angular";

    /**
     *
     */
    constructor() {
        this.Title = "Angular js";
        
    }
}