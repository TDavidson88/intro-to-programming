import { Routes } from '@angular/router';

import { BankingComponent } from './banking.component';
import { DepositComponent } from './components/deposit.component';
import { BankStore } from './services/bank.store';
import { WithdrawalComponent } from './components/withdrawal.component';

export const BANKING_ROUTES: Routes = [
  {
    path: '',

    component: BankingComponent,
    providers: [BankStore],

    children: [
      {
        path: 'withdrawal',
        component: WithdrawalComponent,
      },
      {
        path: 'deposit',
        component: DepositComponent,
      },
    ],
  },
];
