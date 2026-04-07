import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { RegistroDTO } from "../models/registro.model";

@Injectable({providedIn: 'root'})
export class AuthService {
    private apiUrl = 'http://localhost:5000/api/auth';

    constructor(private http: HttpClient) {}

    registrar(dto: RegistroDTO): Observable<any> {
        return this.http.post(`${this.apiUrl}/register`, dto);
    }
}