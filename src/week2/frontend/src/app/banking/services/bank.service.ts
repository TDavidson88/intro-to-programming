import { signal } from '@angular/core';

export class BankService {
  private _currentBalance = signal(5000);

  public getCurrentBalance() {
    return this._currentBalance.asReadonly();
  }

  public deposit(amount: number) {
    //business logic will go here
    this._currentBalance.update((balance) => balance + amount);
  }

  public withdrawal(amount: number) {
    //business logic will go here
    this._currentBalance.update((balance) => balance - amount);
  }
}
