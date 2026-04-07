import { Component, OnInit} from '@angular/core';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { AuthService } from '../core/services/auth.service';

@Component({
  selector: 'app-registro',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './registro.html',
  styleUrl: './registro.css',
})
export class Registro implements OnInit {
  registroForm!: FormGroup;
  loading = false;
  mensaje = '';

  constructor(private fb: FormBuilder, private authService: AuthService) {}

  ngOnInit() {
  this.registroForm = this.fb.group({
    nombre: ['', [Validators.required, Validators.pattern(/^[a-zA-ZáéíóúÁÉÍÓÚñÑ'-]+$/)]],
    apellido: ['', [Validators.required, Validators.pattern(/^[a-zA-ZáéíóúÁÉÍÓÚñÑ'-]+$/)]],
    telefono: ['', [Validators.required, Validators.pattern(/^[0-9+\s-]{7,15}$/)]],
    email: ['', [Validators.required, Validators.email]],
    password: ['', [Validators.required, Validators.minLength(8)]]
  });
}

  onsubmit(): void {
    if (this.registroForm.invalid) {
      this.registroForm.markAllAsTouched();
      return;
    }

    this.loading = true;
    this.mensaje = '';

    this.authService.registrar(this.registroForm.value).subscribe({
      next: (res) => {
        this.mensaje = res.message || "¡Registro Exitoso!";
        this.registroForm.reset();
      },
      error: (err) => {
        this.mensaje = err.error?.message || "Error de conexión";
      },
      complete: () => {
        this.loading = false;
      }
    });    
}

}