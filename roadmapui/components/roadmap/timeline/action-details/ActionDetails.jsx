"use client"

import "./action-details.css"
import {useRoadmapContext} from "@/app/roadmaps/layout";
import Dialog from "@/components/dialog/Dialog";
import EditTaskDialog from "@/components/roadmap/create/EditTaskDialog";
import TaskTypeIcon from "@/models/enums/TaskTypeIcon";
import Service from "@/services";
import {useEffect , useState} from "react";


export default function ActionDetails({actionId , open , handleClose , _action}) {
    const {setRoadmap , readMode} = useRoadmapContext()
    const [action, setAction] = useState({});
    const [taskToEdit , setTaskToEdit] = useState({});
    const [editTask , setEditTask] = useState(false);
    const [loading, setLoading] = useState(true);

    const inputHandler = (e) => {
        const {name , value} = e.target
        action[name] = value;
        setRoadmap((prev) => ({...prev}));
    }

    useEffect(() => {
        const fetchData = async () => {
            try {
                const data = await Service.ActionService.findById(actionId);
                setAction(data);
                setLoading(false);
                console.log('Fetched Action:', data);
            } catch (error) {
                console.error('Error fetching roadmap:', error);
            }
        };

        if (actionId !== undefined) {
            fetchData().catch(err => console.log(err));
        } else if (_action !== undefined) {
            setAction(_action)
            setLoading(false)
        }
    } , [actionId , _action]);

    return (<>
        <Dialog onClose={handleClose}>
            <div className="action-details">
                {loading && <>Loading</>}
                {!loading &&
                    <>
                        {readMode? <>
                            <h2 className="action__title">{action?.title}</h2>
                            <p className="action__description">{action?.description}</p>
                            <div className="tasks">
                                {action?.tasks?.map(task => <>
                                    <a className="task" target="_blank" href={task?.link}
                                       key={task?.id? task.id: action.tasks.indexOf(task)}>
                                        <div className="task__icon">{TaskTypeIcon[task?.type]()}</div>
                                        <div className="separator"><span></span><span></span></div>
                                        <div className="task__title">{task?.title}</div>
                                    </a>
                                </>)}
                            </div>
                        </>: <>
                            <h2 className="action__title">
                                <input name="title" type="text"
                                       onChange={inputHandler}
                                       value={action.title}/>
                            </h2>
                            <p className="action__description">
                                <textarea
                                    name="description"
                                    onChange={inputHandler}
                                    value={action.description}>
                                </textarea>
                            </p>
                            <div className="tasks">
                                {action?.tasks?.map(task => <>
                                    <a className="task" onClick={() => {
                                        setTaskToEdit(task);
                                        setEditTask(true)
                                    }}
                                       key={task?.id? task.id: action.tasks.indexOf(task)}>
                                        <div className="task__icon">{TaskTypeIcon[task?.type]()}</div>
                                        <div className="separator"><span></span><span></span></div>
                                        <div className="task__title">{task?.title}</div>
                                    </a>
                                </>)}
                            </div>
                        </>}
                    </>}
            </div>
        </Dialog>

        {editTask && <EditTaskDialog onClose={() => setEditTask(false)} _task={taskToEdit}/>}
    </>)
}
