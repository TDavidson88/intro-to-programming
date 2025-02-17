import { Routes } from '@angular/router';
import { ResourcesComponent } from './resources.component';

export const RESOURCES_ROUTES: Routes = [
  {
    path: 'resources',
    loadChildren: () =>
      import('../resources/resources.routes').then((r) => r.RESOURCES_ROUTES),
  },
];
