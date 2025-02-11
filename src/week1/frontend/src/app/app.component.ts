import { Component } from '@angular/core';

import { RouterLink, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  template: `
    <main
      class="container mx-auto flex flex-col items-center justify-center min-h-screen"
    >
      <div class="flex gap-4 mb-4">
        <a routerLink="/" class="btn btn-primary">Home</a>
        <a routerLink="/todo-list" class="btn btn-primary">See My Todo List</a>
        <a class="btn btn-primary">Add An Item To My Todo List</a>
      </div>
      <div class="w-full flex justify-center">
        <router-outlet></router-outlet>
      </div>
    </main>
  `,
  styles: [],
  imports: [RouterLink, RouterOutlet],
})
export class AppComponent {}
