import {RoadmapIcon} from "@/components/utils/icons";
import RoadmapSection from "@/components/roadmap/timeline/roadmap-section/RoadmapSection";

import "./roadmap-details.css"
import {useRoadmapContext} from "@/app/roadmaps/layout";

export default function RoadmapDetails() {
    const {roadmap, createMode, updateMode} = useRoadmapContext()

    return (<>
        <div className="roadmap">
            <div className="aside"></div>
            <main>
                <section className="roadmap__detail">
                    <RoadmapIcon className="roadmap__icon"/>
                    <h2 className="roadmap__title">{roadmap.title}</h2>
                    <p className="roadmap__desc">{roadmap.description}</p>
                </section>

                {(roadmap?.start || (updateMode || createMode)) && <RoadmapSection data={roadmap.start}/>}
            </main>
        </div>
    </>)
}
