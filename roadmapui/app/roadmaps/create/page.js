"use client"

import RoadmapDetails from "@/components/roadmap/timeline/roadmap-details/RoadmapDetails";
import {useRoadmapContext} from "@/app/roadmaps/layout";
import {useEffect, useState} from "react";
import CreateRoadmapDialog from "@/components/roadmap/create/CreateRoadmapDialog";

export default function CreateRoadmapPage() {
    const {roadmap, setRoadmap, modeChanger, createMode} = useRoadmapContext();
    const [showCreateRoadmapDialog, setShowCreateRoadmapDialog] = useState(true);

    // change the mode to create
    useEffect(() => {
        modeChanger.create()
    }, [createMode]);

    return (<>
        <RoadmapDetails/>
        {showCreateRoadmapDialog && <CreateRoadmapDialog onClose={() => setShowCreateRoadmapDialog(false)}/>}
    </>)
}
