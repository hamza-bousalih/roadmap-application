"use client"

import "./action-details.css"
import TaskTypeIcon from "@/models/enums/TaskTypeIcon";
import Service from "@/services";
import {Modal} from "@mui/material";
import {useEffect , useState} from "react";


export default function ActionDetails({actionId , open , handleClose , _action}) {
    const [action, setAction] = useState({});
    const [loading, setLoading] = useState(true);

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
        <Modal
            open={open}
            onClose={handleClose}
            aria-labelledby="modal-modal-title"
            aria-describedby="modal-modal-description"
        >
            <div className="action-details">
                {loading && <>Loading</>}
                {!loading &&
                    <>
                        <h2 className="action__title">{action?.title}</h2>
                        <p className="action__description">{action?.description}</p>
                        <div className="tasks">
                            {action?.tasks?.map(task => <>
                                <a
                                    className="task" target="_blank" href={task?.link}
                                    key={task?.id? task.id: action.tasks.indexOf(task)}>
                                    <div className="task__icon">{TaskTypeIcon[task?.type]()}</div>
                                    <div className="separator"><span></span><span></span></div>
                                    <div className="task__title">{task?.title}</div>
                                </a>
                            </>)}
                        </div>
                    </>}
            </div>
        </Modal>
    </>)
}
