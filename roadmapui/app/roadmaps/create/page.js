"use client"

import RoadmapDetails from "@/components/roadmap/timeline/roadmap-details/RoadmapDetails";
import {RoadmapContext} from "@/app/roadmaps/layout";
import {useContext} from "react";

export default function CreateRoadmapPage({}) {
    const {roadmap, setRoadmap} = useContext(RoadmapContext);

    return (<>
        <RoadmapDetails roadmap={roadmap}/>
    </>)
}
