import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BalanceService } from './balance.service';

@Component({
  selector: 'app-balance',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './balance.component.html',
  styleUrls: ['./balance.component.css']
})
export class BalanceComponent implements OnInit {
  customerName = '';
  totalBalance = '';
  accountStatus = '';
  error: string | null = null;

  constructor(private balanceService: BalanceService) {}

  ngOnInit(): void {
    this.balanceService.getBalanceXml().subscribe({
      next: (xmlString) => this.parseXML(xmlString),
      error: () => this.error = 'No se pudo cargar el XML.'
    });
  }

  parseXML(xml: string): void {
    const parser = new DOMParser();
    const xmlDoc = parser.parseFromString(xml, 'application/xml');

    const balanceValue = xmlDoc.querySelector('TotalBalance > Value')?.textContent ?? '';
    if (balanceValue.length > 15) {
      this.error = 'El saldo supera los 15 dígitos y no puede ser mostrado.';
      return;
    }

    this.customerName = xmlDoc.querySelector('CustomerName')?.textContent ?? 'N/A';
    this.totalBalance = balanceValue;
    this.accountStatus = xmlDoc.querySelector('AccountStatus')?.textContent ?? 'N/A';
  }
}
