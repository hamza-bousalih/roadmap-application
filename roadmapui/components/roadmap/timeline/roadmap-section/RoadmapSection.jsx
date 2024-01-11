import RoadmapOption from "@/components/roadmap/timeline/roadmap-option/RoadmapOption";

import "./roadmap-section.css"

export default function RoadmapSection({data}) {
    return <>
        <section className="roadmap-section">
            <div className="roadmap-section__icon">
                {/*current*/}
                {/*<CheckIcon/>*/}
            </div>
            <div className="options">
                {data?.options.map(op => <RoadmapOption key={data.options.indexOf(op)} data={op}/>)}
            </div>
        </section>
        {data?.next && <RoadmapSection data={data.next}/>}
    </>
}
