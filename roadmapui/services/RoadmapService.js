import {ModuleService} from "@/services/service";

class RoadmapService extends ModuleService {
    constructor() {
        super("roadmap");
    }
}

export default new RoadmapService();
