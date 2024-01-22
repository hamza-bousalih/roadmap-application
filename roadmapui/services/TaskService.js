import {ModuleService} from "@/services/Service";

class TaskService extends ModuleService {
    constructor() {
        super("task");
    }
}

export default new TaskService();
