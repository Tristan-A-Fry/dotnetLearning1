import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import {BrowserModule} from '@angular/platform-browser';
import { provideHttpClient } from '@angular/common/http';
@Component({
  selector: 'app-root',
  standalone: true,
  imports: [provideHttpClient],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
})
export class AppComponent {
  title = 'client';
}
