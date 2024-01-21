"use client"

import {useRouter} from "next/navigation";
import {useState} from "react";
import CreateRoadmapDialog from "@/components/roadmap/create/CreateRoadmapDialog";

export default function Home() {
    const [showCreateRoadmapDialog, setShowCreateRoadmapDialog] = useState(true);
    const router = useRouter()

    return <main>
        Home Page
        <ul>
            <li>
                <button onClick={() => router.push("/roadmaps/4")}>Roadmap</button>
            </li>
            <li>
                <button onClick={() => setShowCreateRoadmapDialog(prev => !prev)}>create</button>
            </li>
        </ul>
        {showCreateRoadmapDialog && <CreateRoadmapDialog onClose={() => setShowCreateRoadmapDialog(true)}/>}
    </main>
}
