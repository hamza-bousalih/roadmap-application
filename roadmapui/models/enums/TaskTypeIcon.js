import {
    BookIcon,
    CheckSquareIcon,
    CodeSlashIcon,
    MusicNoteIcon,
    PencilSquareIcon,
    TvIcon
} from "@/components/utils/icons";

const TaskTypeIcon = {
    Watch: () => <TvIcon/>,
    Read: () => <BookIcon/>,
    Write: () => <PencilSquareIcon/>,
    Code: () => <CodeSlashIcon/>,
    Listen: () => <MusicNoteIcon/>,
    Qcm: () => <CheckSquareIcon/>,
}

export const TaskType = {
    Watch: "Watch",
    Read: "Read",
    Write: "Write",
    Code: "Code",
    Listen: "Listen",
    Qcm: "Qcm",
}

export const TaskTypes = [
    TaskType.Watch,
    TaskType.Read,
    TaskType.Write,
    TaskType.Code,
    TaskType.Listen,
    TaskType.Qcm,
]

export default TaskTypeIcon
