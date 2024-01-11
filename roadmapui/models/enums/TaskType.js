import {
    BookIcon,
    CheckSquareIcon,
    CodeSlashIcon,
    MusicNoteIcon,
    PencilSquareIcon,
    TvIcon
} from "@/components/utils/icons";

const TaskType = {
    Watch: () => <TvIcon/>,
    Read: () => <BookIcon/>,
    Write: () => <PencilSquareIcon/>,
    Code: () => <CodeSlashIcon/>,
    Listen: () => <MusicNoteIcon/>,
    Qcm: () => <CheckSquareIcon/>,
}

export default TaskType
