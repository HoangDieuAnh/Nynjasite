import { NewUser } from '../Model/user.model';
import { IUserService } from '../IService/user.interface';
import { Http } from '@angular/http';
import { Injectable } from '@angular/core';

@Injectable()
export class UserService implements IUserService {

    constructor(private http: Http) {
    }

    createUser(user: NewUser) {
        return this.http.post('api/user/createUserAsync', user).subscribe(response => {
            debugger;
                },
            err => {
                debugger;
            });
    }
}