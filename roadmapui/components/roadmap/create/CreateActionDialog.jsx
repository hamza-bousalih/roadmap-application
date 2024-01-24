"use client"

import Dialog , {
    DialogBody , DialogButton , DialogFooter , DialogForm , DialogSection , Labeled , LongTextInput , TextInput
} from "@/components/dialog/Dialog";
import CardLabeledWithIcons from "@/components/utils/card-labeled-with-icons/CardLabeledWithIcons";
import {AddIcon , DeleteIcon , FullScreenIcon , RemoveIcon} from "@/components/utils/icons";
import {useState} from "react";


const taskInit = {title: "" , type: "" , description: "" , link: ""}
export default function CreateActionDialog({onClose, addAction}) {
    const initAction = () => ({title: "" , description: "" , tasks: []});

    const [task , setTask] = useState({...taskInit});
    const [newAction , setNewAction] = useState(initAction);
    const [taskIndex , setTaskIndex] = useState(0);
    const [editTaskMode , setEditTaskMode] = useState(false);

    const handleActionInput = (event) => {
        const {name, value} = event.target
        setNewAction((prev) => ({...prev, [name]: value}));
    }

    const handleTaskInput = (event) => {
        const {name , value} = event.target
        setTask((prev) => ({...prev , [name]: value}));
    }

    const addTaskHandler = () => {
        if (!editTaskMode) {
            newAction.tasks.push(task)
            setNewAction(prev => ({...prev}))
            setTask({...taskInit})
            return;
        }
        newAction.tasks[taskIndex] = task;
        setNewAction(prev => ({...prev}));
        setEditTaskMode(false)
        setTask({...taskInit})
    }

    const submitHandler = () => {
        addAction(newAction)
        console.log(newAction)
        setNewAction(initAction)
        onClose()
    }

    const editTask = (taskToEdit) => {
        setEditTaskMode(true)
        setTask(taskToEdit)
        setTaskIndex(newAction.tasks.indexOf(taskToEdit))
    }

    const removeTask = (task , reset) => {
        const index = newAction.tasks.indexOf(task);
        if (index === -1) {
            console.log("taks not found in the list")
            return;
        }
        newAction.tasks.splice(index , 1);
        setNewAction(prev => ({...prev}))
        if (reset) {
            setEditTaskMode(false)
            setTask({...taskInit})
        }
    }

    return <>
        <Dialog
            onClose={onClose}
            divided={true}
        >
            <DialogBody>

                <DialogSection title="Create New Action">
                    <DialogForm>
                        <TextInput defaultValue={newAction.title} id="title" placeholder="Title for your roadmap"
                                   onChange={handleActionInput}/>
                        <LongTextInput defaultValue={newAction.description} id="description"
                                       placeholder="Description for your roadmap" onChange={handleActionInput}/>
                        {newAction.tasks.length > 0 && <>
                            <Labeled label="Tasks">
                                {newAction.tasks.map(task => <CardLabeledWithIcons
                                    key={newAction.tasks.indexOf(task)} label={task.title}
                                    icons={[<FullScreenIcon key={1} clickable={true} onclick={() => editTask(task)}/> ,
                                        <RemoveIcon key={2} clickable={true} onclick={() => removeTask(task)}/>]}
                                />)}
                            </Labeled>
                        </>}
                    </DialogForm>
                    <DialogFooter>
                        <DialogButton label="Save Action" onClick={submitHandler}/>
                    </DialogFooter>
                </DialogSection>

                <DialogSection title="Add a Task">
                    <DialogForm>
                        <TextInput onChange={handleTaskInput}
                                   id="title" defaultValue={task.title}
                                   placeholder="Title for your roadmap"/>
                        <TextInput onChange={handleTaskInput}
                                   id="type" defaultValue={task.type}
                                   placeholder="Description for your roadmap"/>
                        <TextInput onChange={handleTaskInput}
                                   id="link" defaultValue={task.link} label="Page Link"
                                   placeholder="Description for your roadmap"/>
                        <LongTextInput onChange={handleTaskInput}
                                       id="description" defaultValue={task.description}
                                       placeholder="Description for your roadmap"/>
                    </DialogForm>
                    <DialogFooter>
                        {editTaskMode && <DialogButton
                            icon={<DeleteIcon/>} label="Delete"
                            onClick={() => removeTask(task , true)}
                            className="small right danger"/>}
                        <DialogButton
                            icon={!editTaskMode? <AddIcon/>: undefined}
                            label={editTaskMode? "Update": "Add"} onClick={addTaskHandler} className="small right"/>
                    </DialogFooter>
                </DialogSection>

            </DialogBody>
        </Dialog>
    </>
}

