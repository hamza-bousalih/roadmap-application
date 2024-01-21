"use client"

import {useRouter} from "next/navigation";

export default function Home() {
    const router = useRouter()

    return <main>
        Home Page
        <ul>
            <li>
                <button onClick={() => router.push("/roadmaps/4")}>Roadmap</button>
            </li>
            <li>
                <button onClick={() => router.push("/roadmaps/create")}>create</button>
            </li>
        </ul>
    </main>
}
