import Dialog, {DialogBody, DialogFooter, LongTextInput, SubmitButton, TextInput} from "@/components/dialog/Dialog";
import {useState} from "react";
import {useRouter} from "next/navigation";

export default function CreateRoadmapDialog({onClose}) {
    const route  = useRouter()

    const [newRoadmap, setNewRoadmap] = useState({
        title: "", description: "", // tags: [],
    });

    const handleInput = (event) => {
        const {name, value} = event.target
        setNewRoadmap((prev) => ({...prev, [name]: value}));
    }

    const onCloseHandler = () => {
        onClose()
    }

    const handleSubmit = () => {
        console.log(`/roadmaps/create/${newRoadmap.title}/${newRoadmap.description}`)
        route.push(`/roadmaps/create/${newRoadmap.title}/${newRoadmap.description}`)
    }

    return <>
        <Dialog
            onClose={onCloseHandler}
            title="Create New Roadmap"
            description="Enter The title and description for your raodmap."
        >
            <DialogBody>
                <TextInput
                    id="title"
                    placeholder="Title for your roadmap"
                    onChange={handleInput}/>
                <LongTextInput
                    id="description"
                    placeholder="Description for your roadmap"
                    onChange={handleInput}/>
                {/*<TextInput id="tags" label="Tags" placeholder="Entre a tag"/>*/}
            </DialogBody>
            <DialogFooter>
                <SubmitButton
                    label="Get Satrt"
                    onClick={handleSubmit}
                />
            </DialogFooter>
        </Dialog>
    </>
}
