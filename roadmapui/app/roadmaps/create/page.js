"use client"

import {useRoadmapContext} from "@/app/roadmaps/layout";
import Button from "@/components/button/Button";
import CreateRoadmapDialog from "@/components/roadmap/create/CreateRoadmapDialog";
import {LoaderOverlay} from "@/components/roadmap/laoder/Loader";
import RoadmapDetails from "@/components/roadmap/timeline/roadmap-details/RoadmapDetails";
import services from "@/services";
import {useEffect , useState} from "react";


export default function CreateRoadmapPage() {
    const {roadmap, setRoadmap, modeChanger, createMode} = useRoadmapContext();
    const [showCreateRoadmapDialog, setShowCreateRoadmapDialog] = useState(true);
    const [creating , setCreating] = useState(false)

    useEffect(() => {
        modeChanger.create()
    }, [createMode]);

    const createHandler = () => {
        setCreating(true)
        console.log(roadmap)
        services.RoadmapService.create(roadmap)
            .finally(() => setCreating(false))
    }

    return (<>
        {creating? <LoaderOverlay/>: null}
        <RoadmapDetails/>
        {<Button className="fixed-right-button" label="Create Now" onClick={createHandler}></Button>}
        {showCreateRoadmapDialog && <CreateRoadmapDialog onClose={() => setShowCreateRoadmapDialog(false)}/>}
    </>)
}
