"use client"

import {CheckCircleIcon, FullScreenIcon} from "@/components/utils/icons";
import {useState} from "react";
import ActionDetails from "@/components/roadmap/timeline/action-details/ActionDetails";

import "./roadmap-action.css"

export default function RoadmapAction({data}) {
    const [showTasks, setShowTasks] = useState(false)

    return <>
        <div className="action" onClick={() => setShowTasks(true)}>
            <span className="action__title">{data?.title}</span>
            <div className="icons">
                {/*{clasName === "done" && <CheckCircleIcon/>}*/}
                <FullScreenIcon className="pointer"/>
            </div>
        </div>
        {data?.next && <RoadmapAction data={data.next} />}
        {showTasks &&
            <ActionDetails
                handleClose={() => setShowTasks(false)}
                actionId={data?.id}
                open={showTasks}
            />
        }
    </>
}
