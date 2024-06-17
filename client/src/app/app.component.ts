import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import {BrowserModule} from '@angular/platform-browser';
@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  imports: [
    BrowserModule]
})
export class AppComponent {
  title = 'client';
}
