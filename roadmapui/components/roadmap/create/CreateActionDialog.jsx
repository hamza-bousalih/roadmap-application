"use client"

import Dialog, {DialogBody, DialogFooter, LongTextInput, SubmitButton, TextInput} from "@/components/dialog/Dialog";
import {useState} from "react";
import {useRoadmapContext} from "@/app/roadmaps/layout";

export default function CreateActionDialog({onClose, addAction}) {
    const [newAction, setNewAction] = useState({});

    const handleInput = (event) => {
        const {name, value} = event.target
        setNewAction((prev) => ({...prev, [name]: value}));
    }

    const onCloseHandler = () => {
        onClose()
    }

    const submitHandler = () => {
        addAction(newAction)
        onClose()
    }

    return <>
        <Dialog
            onClose={onCloseHandler}
            title="Create New Action"
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
            </DialogBody>
            <DialogFooter>
                <SubmitButton label="Push to section" onClick={submitHandler}/>
            </DialogFooter>
        </Dialog>
    </>
}
