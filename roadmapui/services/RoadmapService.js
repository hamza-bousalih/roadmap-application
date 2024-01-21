import {ModuleService} from "@/services/Service";

class RoadmapService extends ModuleService {
    constructor() {
        super("roadmap");
    }
}

export default new RoadmapService();
