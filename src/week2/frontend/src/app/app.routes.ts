import { Routes } from '@angular/router';
import { HomeComponent } from './components/home.component';

export const routes: Routes = [
  {
    path: 'dashboard',
    component: HomeComponent,
  },
  {
    path: 'banking',
    loadChildren: () =>
      import('./banking/banking.routes').then((m) => m.BANKING_ROUTES),
  },
  {
    path: 'resources',
    loadChildren: () =>
      import('./resources/resources.routes').then((r) => r.RESOURCES_ROUTES),
  },
  {
    path: '**', //catchall route but needs to be last
    redirectTo: 'dashboard',
  },
];
