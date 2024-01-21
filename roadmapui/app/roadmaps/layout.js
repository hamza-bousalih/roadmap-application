"use client"

import '@/styles/fonts.css'
import '@/styles/colors.css'
import '@/styles/globals.css'
import {createContext, useContext, useState} from "react";

export const RoadmapContext = createContext();
export const useRoadmapContext = () => useContext(RoadmapContext)

export default function RootLayout({children}) {
    const [roadmap, setRoadmap] = useState({})

    return (
        <html lang="en">
        <body>
        <RoadmapContext.Provider value={{roadmap, setRoadmap}}>
            {children}
        </RoadmapContext.Provider>
        </body>
        </html>
    )
}
