"use client"

import RoadmapDetails from "@/components/roadmap/timeline/roadmap-details/RoadmapDetails";
import {useRoadmapContext} from "@/app/roadmaps/layout";
import {useState} from "react";
import CreateRoadmapDialog from "@/components/roadmap/create/CreateRoadmapDialog";

export default function CreateRoadmapPage({}) {
    const {roadmap, setRoadmap, modeChanger} = useRoadmapContext();
    const [showCreateRoadmapDialog, setShowCreateRoadmapDialog] = useState(true);

    // change the mode to create
    modeChanger.create()

    return (<>
        <RoadmapDetails roadmap={roadmap}/>
        {showCreateRoadmapDialog && <CreateRoadmapDialog onClose={() => setShowCreateRoadmapDialog(false)}/>}
    </>)
}
