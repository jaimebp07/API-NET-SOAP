import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { BalanceComponent } from './balance/balance.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, BalanceComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'frontend';
}
