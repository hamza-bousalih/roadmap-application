"use client"

import Dialog, {
    DialogBody,
    DialogFooter,
    DialogForm,
    DialogSection,
    LongTextInput,
    SubmitButton,
    TextInput
} from "@/components/dialog/Dialog";
import {useState} from "react";
import {useRoadmapContext} from "@/app/roadmaps/layout";
import {AddIcon} from "@/components/utils/icons";

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
            divided={true}
        >
            <DialogBody>

                <DialogSection title="Create New Action">
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
                    <DialogFooter>
                        <SubmitButton label="Save Action" onClick={submitHandler}/>
                    </DialogFooter>
                </DialogSection>

                <DialogSection title="Add a Task">
                    <DialogForm>
                        <TextInput
                            id="title"
                            placeholder="Title for your roadmap"
                            onChange={handleInput}/>
                        <TextInput
                            id="type"
                            placeholder="Description for your roadmap"
                            onChange={handleInput}/>
                        <TextInput
                            id="link" label="Page Link"
                            placeholder="Description for your roadmap"
                            onChange={handleInput}/>
                        <LongTextInput
                            id="description"
                            placeholder="Description for your roadmap"
                            onChange={handleInput}/>
                    </DialogForm>
                    <DialogFooter>
                        <SubmitButton icon={<AddIcon/>} label="Add" onClick={submitHandler} className="small right"/>
                    </DialogFooter>
                </DialogSection>

            </DialogBody>
        </Dialog>
    </>
}
