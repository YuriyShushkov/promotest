import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  ngOnInit() {
  }

  @Input() error: string | null | undefined;

  @Output() submitEM = new EventEmitter();

  title = 'promotest.client';
}
