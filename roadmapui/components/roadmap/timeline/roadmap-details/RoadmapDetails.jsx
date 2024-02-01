import {useRoadmapContext} from "@/app/roadmaps/layout";
import RoadmapSection from "@/components/roadmap/timeline/roadmap-section/RoadmapSection";

import "./roadmap-details.css"
import {RoadmapIcon} from "@/components/utils/icons";


export default function RoadmapDetails() {
    const {roadmap , setRoadmap , createMode , updateMode , readMode} = useRoadmapContext()

    const inputHandler = (e) => {
        const {name , value} = e.target
        setRoadmap((prev) => ({...prev , [name]: value}));
    }

    return (<>
        <div className="roadmap">
            <div className="aside"></div>
            <main>
                <section className="roadmap__detail">
                    <RoadmapIcon className="roadmap__icon"/>
                    {readMode? <>
                        <h2 className="roadmap__title">{roadmap.title}</h2>
                        <p className="roadmap__desc">{roadmap.description}</p>
                    </>: <>
                        <h2 className="roadmap__title">
                            <input
                                name="title" type="text"
                                onChange={inputHandler}
                                value={roadmap.title}/>
                        </h2>
                        <p className="roadmap__desc">
                            <textarea
                                name="description"
                                onChange={inputHandler}
                                value={roadmap.description}>
                            </textarea>
                        </p>
                    </>}
                </section>

                {(roadmap?.start || (updateMode || createMode)) && <RoadmapSection data={roadmap.start}/>}
            </main>
        </div>
    </>)
}
