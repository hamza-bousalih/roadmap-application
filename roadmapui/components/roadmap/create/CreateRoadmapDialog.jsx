"use client"

import Dialog, {
    DialogBody,
    DialogFooter,
    DialogForm,
    LongTextInput,
    SubmitButton,
    TextInput
} from "@/components/dialog/Dialog";
import {useRoadmapContext} from "@/app/roadmaps/layout";

export default function CreateRoadmapDialog({onClose}) {
    const  {roadmap, setRoadmap} = useRoadmapContext();

    const handleInput = (event) => {
        const {name, value} = event.target
        setRoadmap((prev) => ({...prev, [name]: value}));
    }

    const onCloseHandler = () => {
        setRoadmap({title: "Raodmap title", description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris ex odio, tempor sit amet augueid, malesuada ultricies leo. Vestibulum ultrices elit sit amet efficitur semper. In iaculis suscipit elit in vulputate. Ut a dictumorci. Nunc mollis sapien laoreet felis aliquam blandit. Nunc at tellus vel sem consequat malesuada ut molestie odio. Suspendisse potenti ."})
        onClose()
    }

    return <>
        <Dialog
            // onClose={null}
            title="Create New Roadmap"
            description="Enter The title and description for your raodmap."
        >
            <DialogBody>
                <DialogForm>
                    <TextInput
                        id="title" defaultValue={roadmap.title}
                        placeholder="Title for your roadmap"
                        onChange={handleInput}/>
                    <LongTextInput
                        id="description" defaultValue={roadmap.description}
                        placeholder="Description for your roadmap"
                        onChange={handleInput}/>
                    {/*<TextInput id="tags" label="Tags" placeholder="Entre a tag"/>*/}
                </DialogForm>
            </DialogBody>
            <DialogFooter>
                <SubmitButton label="Get Satrt" onClick={onCloseHandler}/>
            </DialogFooter>
        </Dialog>
    </>
}
