"use client"

import {useRoadmapContext} from "@/app/roadmaps/layout";
import Button from "@/components/button/Button";
import Navbar from "@/components/navbar/navbar";
import Loader from "@/components/roadmap/laoder/Loader";
import RoadmapDetails from "@/components/roadmap/timeline/roadmap-details/RoadmapDetails";
import Service from "@/services";
import {useRouter} from "next/navigation";
import {useEffect , useState} from "react";


export default function RoadmapPage({params: {roadmapId}}) {
    const {roadmap , setRoadmap , modeChanger , updateMode , readMode} = useRoadmapContext();
    const [loading, setLoading] = useState(true);
    const router = useRouter()

    useEffect(() => {
        modeChanger.read()
        const fetchData = async () => {
            try {
                const data = await Service.RoadmapService.findById(roadmapId);
                setRoadmap(data);
                setLoading(false);
                console.log('Fetched Roadmap:', data);
            } catch (error) {
                console.error('Error fetching roadmap:', error);
            }
        };

        fetchData().catch(err => console.log(err));
    }, [roadmapId]);

    const editHandler = () => {
        console.log(roadmap)
        modeChanger.read()
        // services.RoadmapService.update(roadmap)
        //     .then(data => {
        //         console.log(data)
        //         router.push("/roadmaps")
        //     })
        //     .finally(() => modeChanger.read())
    }

    return <>
        {loading && <Loader/>}
        <Navbar />
        {(!loading && roadmap) && <>
            <RoadmapDetails roadmap={roadmap}/>
            {readMode && <Button className="fixed-right-button opacity-30" label="Edit Now"
                                 onClick={_ => modeChanger.update()}></Button>}
            {updateMode && <Button className="fixed-right-button" label="Save Changes" onClick={editHandler}></Button>}
        </>}
    </>
}
