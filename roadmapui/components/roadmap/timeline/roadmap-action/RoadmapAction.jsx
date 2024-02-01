"use client"

import {useRoadmapContext} from "@/app/roadmaps/layout";
import CreateActionDialog from "@/components/roadmap/create/CreateActionDialog";
import ActionDetails from "@/components/roadmap/timeline/action-details/ActionDetails";

import "./roadmap-action.css"
import {FullScreenIcon , PlusIcon} from "@/components/utils/icons";
import {useState} from "react";


export default function RoadmapAction({data, option}) {
    const [showTasks, setShowTasks] = useState(false);
    const {createMode, updateMode} = useRoadmapContext()

    return <>
        {(data === undefined && (updateMode || createMode)) && <AddRoadmapAction option={option}/>}
        {data && <>
            <div className="action" onClick={() => setShowTasks(true)}>
                <span className="action__title">{data.title}</span>
                <div className="icons">
                    {/*{clasName === "done" && <CheckCircleIcon/>}*/}
                    <FullScreenIcon/>
                </div>
            </div>
            {data.next && <RoadmapAction data={data.next}/>}
            {showTasks &&
                <ActionDetails
                    handleClose={() => setShowTasks(false)}
                    actionId={data.id}
                    _action={data}
                    open={showTasks}

                />}
            {(data.next === undefined && (updateMode || createMode)) && <AddRoadmapAction action={data} option={option}/>}
        </>}
    </>
}

export function AddRoadmapAction({action = undefined, option}) {
    const [showDialog, setShowDialog] = useState(true);
    const {setRoadmap} = useRoadmapContext();

    const addAction = (newAction) => {
        if (action !== undefined) action.next = newAction
        else option.start = newAction;
        setRoadmap(prev => ({...prev}))
    }

    return <>
        <div className="action add" onClick={() => setShowDialog(true)}>
            <PlusIcon className="icon"/>
        </div>
        {showDialog && <CreateActionDialog addAction={addAction} option={addAction} onClose={() => setShowDialog(false)}/>}
    </>
}

