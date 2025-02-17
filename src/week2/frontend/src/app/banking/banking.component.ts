import { CurrencyPipe } from '@angular/common';
import {
  Component,
  ChangeDetectionStrategy,
  signal,
  inject,
} from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { BankService } from './services/bank.service';
import { StatusComponent } from './components/status.component';
import { BankStore } from './services/bank.store';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-banking',
  changeDetection: ChangeDetectionStrategy.OnPush,
  //   providers: [BankService],
  imports: [CurrencyPipe, RouterOutlet, RouterLink, StatusComponent],
  template: `
    <div>
      <p>Your Checking Balance is {{ store.currentBalance() | currency }}</p>
      <div>
        <a routerLink="deposit" class="btn btn-xs btn-secondary"
          >Make a Deposit</a
        >
        @if (store.currentBalance() > 0) {
          <a routerLink="withdrawal" class="btn btn-xs btn-secondary"
            >Make a Withdrawal</a
          >
        }
      </div>

      <div>
        <router-outlet />
      </div>
      @if (showWarning()) {
        <app-banking-status
          [message]="theMessage()"
          (alertClosed)="showWarning.set(false)"
        />
      }
    </div>
  `,
  styles: ``,
})
export class BankingComponent {
  store = inject(BankStore);
  //   currentBalance = this.store.getCurrentBalance();
  form = new FormGroup({
    amount: new FormControl<number>(0, { nonNullable: true }),
  });

  theMessage = signal('The message is: ');

  showWarning = signal<boolean>(true);
}
