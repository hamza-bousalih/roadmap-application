"use client"

import "@/styles/roadmap/roadmap-details.css"
import Service from "@/services"
import {useEffect, useState} from "react";
import Loader from "@/components/roadmap/laoder/Loader";
import RoadmapDetails from "@/components/roadmap/timeline/roadmap-details/RoadmapDetails";
import {useRoadmapContext} from "@/app/layout";

export default function RoadmapPage({params: {roadmapId}}) {
    const {roadmap, setRoadmap} = useRoadmapContext();
    const [loading, setLoading] = useState(true);

    useEffect(() => {
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

    return <>
        {loading && <Loader/>}
        {(!loading && roadmap) && <RoadmapDetails roadmap={roadmap}/>}
    </>
}
