"use client"

import Dialog, {
    DialogBody,
    DialogFooter,
    DialogForm,
    LongTextInput,
    SubmitButton,
    TextInput
} from "@/components/dialog/Dialog";
import {useState} from "react";
import {useRoadmapContext} from "@/app/roadmaps/layout";

export default function CreateOptionDialog({onClose, addOption}) {
    const [newOption, setNewOption] = useState({title: "", description: ""});

    const handleInput = (event) => {
        const {name, value} = event.target
        setNewOption((prev) => ({...prev, [name]: value}));
    }

    const onCloseHandler = () => {
        onClose()
    }

    const submitHandler = () => {
        addOption(newOption)
        onClose()
    }

    return <>
        <Dialog
            onClose={onCloseHandler}
            title="Create New Option"
            description="Enter The title and description for the option."
        >
            <DialogBody>
                <DialogForm>
                    <TextInput
                        id="title"
                        placeholder="Title for your roadmap"
                        onChange={handleInput}/>
                    <LongTextInput
                        id="description"
                        placeholder="Description for your roadmap"
                        onChange={handleInput}/>
                </DialogForm>
            </DialogBody>
            <DialogFooter>
                <SubmitButton label="Push to section" onClick={submitHandler}/>
            </DialogFooter>
        </Dialog>
    </>
}
