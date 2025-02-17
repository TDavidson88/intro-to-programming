import { patchState, signalStore, withMethods, withState } from '@ngrx/signals';

type BankState = {
  currentBalance: number;
};

export const BankStore = signalStore(
  withState<BankState>({
    currentBalance: 0,
  }),
  withMethods((store) => {
    return {
      deposit: (amount: number) =>
        patchState(store, { currentBalance: store.currentBalance() + amount }),
      withdrawal: (amount: number) =>
        patchState(store, { currentBalance: store.currentBalance() - amount }),
    };
  }),
);
