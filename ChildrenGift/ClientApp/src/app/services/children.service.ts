import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { map } from "rxjs/operators"; 

@Injectable({
    providedIn: 'root'
})

export class ChildrenService {
    myAppUrl = '';
    readonly httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };


    constructor(private _http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.myAppUrl = baseUrl;
    }

    getChildren(): Observable<any> {
        return this._http.get<any[]>(this.myAppUrl + 'api/Children/Index');
    }
}
