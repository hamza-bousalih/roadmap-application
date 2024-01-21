"use client"

import '@/styles/fonts.css'
import '@/styles/colors.css'
import '@/styles/globals.css'
import {createContext, useContext, useState} from "react";

export const RoadmapContext = createContext();
export const useRoadmapContext = () => useContext(RoadmapContext)

export default function RootLayout({children}) {
    const [roadmap, setRoadmap] = useState({})
    const [readMode, setReadMode] = useState(true)
    const [createMode, setCreateMode] = useState(false)
    const [updateMode, setUpdateMode] = useState(false)

    const modeChanger = {
        create: () => {
            setCreateMode(true)
            setUpdateMode(false)
            setReadMode(false)
        }, update: () => {
            setCreateMode(false)
            setUpdateMode(true)
            setReadMode(false)
        }, read: () => {
            setCreateMode(false)
            setUpdateMode(false)
            setReadMode(true)
        }
    }

    return (<html lang="en">
        <body>
        <RoadmapContext.Provider value={{roadmap, setRoadmap, createMode, updateMode, modeChanger}}>
            {children}
        </RoadmapContext.Provider>
        </body>
        </html>)
}
