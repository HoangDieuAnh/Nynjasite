import { Component } from '@angular/core';
import { Http } from '@angular/http';
import { FormGroup, FormControl, Validators, FormBuilder } from "@angular/forms";
import { UserService } from '../../Service/user.service';

@Component({
    selector: 'signup',
    templateUrl: './signup.component.html',
    styleUrls: ['./signup.component.less'],
    providers: [UserService]
})
export class SignUpComponent {
    signUpForm: FormGroup
    userService: UserService
    constructor(fb: FormBuilder, userService: UserService) {
        this.signUpForm = fb.group(new NewUser())
        this.userService = userService;
    }

    //scope methods
    onSubmit() {
        this.userService.createUser(this.signUpForm.value);
    }
}

// Classes
class NewUser {
    name: FormControl = new FormControl('', Validators.required);
    password: FormControl = new FormControl('', Validators.required);
    email: FormControl = new FormControl('', Validators.required);
    phoneNumber: FormControl = new FormControl('')
}
