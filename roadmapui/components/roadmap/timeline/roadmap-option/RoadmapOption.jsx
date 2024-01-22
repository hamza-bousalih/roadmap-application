"use client"

import RoadmapAction from "@/components/roadmap/timeline/roadmap-action/RoadmapAction";

import "./roadmap-option.css"
import {PlusIcon} from "@/components/utils/icons";
import {useState} from "react";
import CreateOptionDialog from "@/components/roadmap/create/CreateOptionDialog";
import {useRoadmapContext} from "@/app/roadmaps/layout";

export default function RoadmapOption({data}) {
    const {createMode, updateMode} = useRoadmapContext()

    return <>
        <div className="option-card">
            <h3 className="option-card__title">{data.title}</h3>
            <p className="option-card__desc">{data.description}</p>
            {(data?.start || (updateMode || createMode)) &&
                <div className="actions">
                    <RoadmapAction data={data.start} option={data}/>
                </div>
            }
        </div>
    </>
}

export function AddRoadmapOption({section}) {
    const [showDialog, setShowDialog] = useState(true);
    const {setRoadmap} = useRoadmapContext();

    const addOption = (option) => {
        section.options.push(option)
        setRoadmap(prev => ({...prev}))
    }

    return <>
        <div className="option-card add-option" onClick={() => setShowDialog(true)}>
            <PlusIcon pointer={true}/>
        </div>
        {showDialog && <CreateOptionDialog addOption={addOption} onClose={() => setShowDialog(false)}/>}
    </>
}
