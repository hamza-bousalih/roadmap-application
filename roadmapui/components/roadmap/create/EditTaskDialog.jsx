"use client"

import {useRoadmapContext} from "@/app/roadmaps/layout";
import Dialog , {
    DialogBody , DialogButton , DialogFooter , DialogForm , LongTextInput , SelectInput , TextInput
} from "@/components/dialog/Dialog";
import {TaskTypes} from "@/models/enums";
import {useState} from "react";


export default function EditTaskDialog({onClose , _task}) {
    const {setRoadmap} = useRoadmapContext()
    const [task , setTask] = useState({..._task});

    const handleInput = (event) => {
        const {name , value} = event.target
        setTask((prev) => ({...prev , [name]: value}));
    }

    const onCloseHandler = () => {
        onClose()
    }

    const submitHandler = () => {
        _task.title = task.title;
        _task.description = task.description;
        _task.link = task.link;
        _task.type = task.type;
        setRoadmap(prev => ({...prev}))
        onClose()
    }

    return <>
        <Dialog
            onClose={onCloseHandler}
            title="Edit Task"
            description="Edit Your Selelted Task"
        >
            <DialogBody>
                <DialogForm>
                    <TextInput
                        onChange={handleInput}
                        id="title" defaultValue={task.title}
                        placeholder="Title for your roadmap"
                    />
                    <SelectInput
                        onChange={handleInput}
                        id="type" defaultValue={task.type}>
                        {TaskTypes.map(type => <>
                            <option key={TaskTypes.indexOf(type)} value={type}>{type}</option>
                        </>)}
                    </SelectInput>
                    <TextInput
                        onChange={handleInput}
                        id="link" defaultValue={task.link} label="Page Link"
                        placeholder="Link to the task"
                    />
                    <LongTextInput
                        onChange={handleInput}
                        id="description" defaultValue={task.description}
                        placeholder="Description for your roadmap"
                    />
                </DialogForm>
            </DialogBody>
            <DialogFooter>
                <DialogButton label="Edit Task" onClick={submitHandler}/>
            </DialogFooter>
        </Dialog>
    </>
}
