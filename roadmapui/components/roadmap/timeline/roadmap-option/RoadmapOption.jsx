"use client"

import {useRoadmapContext} from "@/app/roadmaps/layout";
import CreateOptionDialog from "@/components/roadmap/create/CreateOptionDialog";
import RoadmapAction from "@/components/roadmap/timeline/roadmap-action/RoadmapAction";

import "./roadmap-option.css"
import {PlusIcon} from "@/components/utils/icons";
import {useState} from "react";


export default function RoadmapOption({data}) {
    const {createMode , updateMode , readMode , setRoadmap} = useRoadmapContext()

    const inputHandler = (e) => {
        const {name , value} = e.target
        data[name] = value;
        setRoadmap((prev) => ({...prev}));
    }

    return <>
        <div className="option-card">
            {readMode? <>
                <h3 className="option-card__title">{data.title}</h3>
                <p className="option-card__desc">{data.description}</p>
            </>: <>
                <h3 className="option-card__title">
                    <input
                        name="title" type="text"
                        onChange={inputHandler}
                        value={data.title}/>
                </h3>
                <p className="option-card__desc">
                <textarea
                    name="description"
                    onChange={inputHandler}
                    value={data.description}>
                </textarea>
                </p>
            </>}
            {(data?.start || (updateMode || createMode)) && <div className="actions">
                <RoadmapAction data={data.start} option={data}/>
            </div>}
        </div>
    </>
}

export function AddRoadmapOption({section}) {
    const {createMode} = useRoadmapContext()
    const [showDialog , setShowDialog] = useState(createMode);
    const {setRoadmap} = useRoadmapContext();

    const addOption = (option) => {
        section.options.push(option)
        setRoadmap(prev => ({...prev}))
    }

    return <>
        <div className="option-card add-option" onClick={() => setShowDialog(true)}><PlusIcon/></div>
        {showDialog && <CreateOptionDialog addOption={addOption} onClose={() => setShowDialog(false)}/>}
    </>
}
