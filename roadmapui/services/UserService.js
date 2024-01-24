import {ModuleService} from "@/services/Service";

class UserService extends ModuleService {
    constructor() {
        super("user");
    }
}

export default new UserService();
