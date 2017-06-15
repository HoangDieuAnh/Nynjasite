import { NewUser } from '../Model/user.model';

export interface IUserService {
    createUser(user: NewUser):void;
}
