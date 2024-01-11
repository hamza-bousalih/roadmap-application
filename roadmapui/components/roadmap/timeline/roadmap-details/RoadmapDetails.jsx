import {RoadmapIcon} from "@/components/utils/icons";
import RoadmapSection from "@/components/roadmap/timeline/roadmap-section/RoadmapSection";

import "./roadmap-details.css"

export default function RoadmapDetails({roadmap}) {
    return (<>
        <div className="roadmap">
            <div className="aside"></div>
            <main>
                <section className="roadmap__detail">
                    <RoadmapIcon className="roadmap__icon"/>
                    <h2 className="roadmap__title">{roadmap.title}</h2>
                    <p className="roadmap__desc">{roadmap.description}</p>
                </section>

                {roadmap.start && <RoadmapSection data={roadmap.start}/>}
            </main>
        </div>
    </>)
}
