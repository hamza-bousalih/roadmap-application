"use client"

import Dialog, {DialogBody, DialogFooter, LongTextInput, SubmitButton, TextInput} from "@/components/dialog/Dialog";
import {useRoadmapContext} from "@/app/roadmaps/layout";

export default function CreateRoadmapDialog({onClose}) {
    const  {roadmap, setRoadmap} = useRoadmapContext();

    const handleInput = (event) => {
        const {name, value} = event.target
        setRoadmap((prev) => ({...prev, [name]: value}));
    }

    const onCloseHandler = () => {
        onClose()
    }

    return <>
        <Dialog
            onClose={onCloseHandler}
            title="Create New Roadmap"
            description="Enter The title and description for your raodmap."
        >
            <DialogBody>
                <TextInput
                    id="title" defaultValue={roadmap.title}
                    placeholder="Title for your roadmap"
                    onChange={handleInput}/>
                <LongTextInput
                    id="description" defaultValue={roadmap.description}
                    placeholder="Description for your roadmap"
                    onChange={handleInput}/>
                {/*<TextInput id="tags" label="Tags" placeholder="Entre a tag"/>*/}
            </DialogBody>
            <DialogFooter>
                <SubmitButton label="Get Satrt" onClick={onCloseHandler}/>
            </DialogFooter>
        </Dialog>
    </>
}
