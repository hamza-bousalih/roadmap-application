import RoadmapOption, {AddRoadmapOption} from "@/components/roadmap/timeline/roadmap-option/RoadmapOption";

import "./roadmap-section.css"
import {useRoadmapContext} from "@/app/roadmaps/layout";
import {PlusIcon} from "@/components/utils/icons";

export default function RoadmapSection({data}) {
    const {roadmap, setRoadmap, createMode, updateMode, readMode} = useRoadmapContext()

    const addSectionHandler = () => {
        const newSection = {options: []}
        if (data === undefined) {
            setRoadmap(prev => ({...prev, start: newSection}))
        } else {
            data.next = newSection
            setRoadmap(prev => ({...prev}))
        }
    }

    return <>
        {((createMode || updateMode) && !data) && <>
            <section className="roadmap-section">
                <div className="roadmap-section__icon add" onClick={addSectionHandler}>
                    <PlusIcon/>
                </div>
            </section>
        </>}
        {data && <>
            <section className="roadmap-section">
                <div className="roadmap-section__icon">
                    {/*current*/}
                    {/*<CheckIcon/>*/}
                </div>
                <div className="options">
                    {data?.options?.map(op => <RoadmapOption key={data.options.indexOf(op)} data={op}/>)}
                    {(createMode || updateMode) &&  <AddRoadmapOption section={data}/>}
                </div>
            </section>
            {((createMode || updateMode) && !data.next) && <>
                <section className="roadmap-section">
                    <div className="roadmap-section__icon add" onClick={addSectionHandler}>
                        <PlusIcon/>
                    </div>
                </section>
            </>}
        </>}
        {data?.next && <RoadmapSection data={data.next}/>}
    </>
}
