import { Component, Inject } from '@angular/core';
import { Http, Headers, RequestOptions, Response } from '@angular/http';
import { Observable } from 'rxjs';
import 'rxjs/add/operator/map'

@Component({
    selector: 'friends',
    templateUrl: './friends.component.html'
})
export class FriendsComponent {
    public friends: Friends[];
    public friendsLocated: FriendsLocated[];
    public message: string;

    //public tempToken: string;
    //private headers = new Headers({ 'Content-Type': 'application/json' });
    //private options = new RequestOptions({ headers: this.headers });


    private token: string;//'Bearer ' + JSON.parse(this.tempToken).token;
    private headers = new Headers({ 'Content-Type': 'application/json', 'Authorization': this.token });
    private options = new RequestOptions({ headers: this.headers });

    constructor(private http: Http) {
        this.load();
    }

    load() {
        this.http.get('http://localhost:61345/api/Friends', this.options).subscribe(result => {
            this.friends = result.json() as Friends[];
        }, error => this.message = error);
    }
    locateFriend(id: number) {
        console.log(id);
        this.http.get('http://localhost:61345/api/LocateFriend/' + id, this.options).subscribe(result => {
            this.friendsLocated = result.json() as FriendsLocated[];
        }, error => console.error(error));
    }

    login() {
        
        this.http.get('http://localhost:61345/api/Token')
            .subscribe((response: Response) => {
                // login successful if there's a jwt token in the response
                console.log(response);
                let token = response.json() && response.json().accessToken;
                console.log(token);
                if (token) {
                    // Atribui a propriedade token 
                    this.token = 'Bearer ' + token;
                    //Armazenar o nome de usuário e jwt token no local store para manter o usuário conectado entre as atualizações de página
                    localStorage.setItem('currentUser', JSON.stringify({ token: token }));

                    // Returna verdadeiro para indicar o login bem-sucedido
                    this.headers = new Headers({ 'Content-Type': 'application/json', 'Authorization': this.token });
                    this.options = new RequestOptions({ headers: this.headers });
                    this.load();
                    console.log(token);
                    return true;
                } else {
                    // Retorna falso para indicar uma falha de login
                    return false;
                }
            });
    }
}

interface Friends {
    id: number;
    name: string;
}

interface FriendsLocated {
    id: number;
    name: string;
    distance: number;
    path: string;
    coordinates: string;
}