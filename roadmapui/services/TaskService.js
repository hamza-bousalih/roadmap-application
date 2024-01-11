import {ModuleService} from "@/services/service";

class TaskService extends ModuleService {
    constructor() {
        super("task");
    }
}

export default new TaskService();
