"use client"

import {CheckCircleIcon, FullScreenIcon, PlusIcon} from "@/components/utils/icons";
import {useState} from "react";
import ActionDetails from "@/components/roadmap/timeline/action-details/ActionDetails";

import "./roadmap-action.css"
import {useRoadmapContext} from "@/app/roadmaps/layout";

export default function RoadmapAction({data, option}) {
    const {roadmap, setRoadmap, createMode, updateMode, readMode} = useRoadmapContext()
    const [showTasks, setShowTasks] = useState(false)

    const addSectionHandler = (newAction) => {
        if (data === undefined) {
            option.start = newAction
            setRoadmap(prev => ({...prev}))
        } else {
            data.next = newAction
            setRoadmap(prev => ({...prev}))
        }
    }

    return <>
        {((createMode || updateMode) && !data) && <>
            <div className="action add">
                <PlusIcon className="icon"/>
            </div>
        </>}
        {data && <>
            <div className="action" onClick={() => setShowTasks(true)}>
                <span className="action__title">{data?.title}</span>
                <div className="icons">
                    {/*{clasName === "done" && <CheckCircleIcon/>}*/}
                    <FullScreenIcon className="pointer"/>
                </div>
            </div>
            {((createMode || updateMode) && !data.next) && <>
                <div className="action add">
                    <PlusIcon className="icon"/>
                </div>
            </>}
            {data?.next && <RoadmapAction data={data.next}/>}
            {showTasks &&
                <ActionDetails
                    handleClose={() => setShowTasks(false)}
                    actionId={data?.id}
                    open={showTasks}
                />
            }
        </>}
    </>
}

export function AddRoadmapAction({section}) {
    const [showDialog, setShowDialog] = useState(true);
    const {setRoadmap} = useRoadmapContext();

    const addAction = (option) => {
        section.options.push(option)
        setRoadmap(prev => ({...prev}))
    }

    return <>
        <div className="option-card add-option" onClick={() => setShowDialog(true)}>
            <PlusIcon pointer={true}/>
        </div>
        {/*{showDialog && <CreateOptionDialog addOption={addAction} onClose={() => setShowDialog(false)}/>}*/}
    </>
}

