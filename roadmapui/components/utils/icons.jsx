import 'bootstrap-icons/font/bootstrap-icons.css'

function setIcon(icon, className) {
    return `bi bi-${icon} ${className}`
}

function RoadmapIcon({className, onclick}) {
    return <i onClick={onclick} className={setIcon("map-fill", className)}></i>
}

function CheckIcon({className, onclick}) {
    return <i onClick={onclick} className={setIcon("check", className)}></i>
}

function CheckCircleIcon({className, onclick}) {
    return <i onClick={onclick} className={setIcon("check2-circle", className)}></i>
}

function FullScreenIcon({className, onclick}) {
    return <i onClick={onclick} className={setIcon("fullscreen", className)}></i>
}

function FullScreenExitIcon({className, onclick}) {
    return <i onClick={onclick} className={setIcon("fullscreen-exit", className)}></i>
}

function GoeAltIcon({className, onclick}) {
    return <i onClick={onclick} className={setIcon("geo-alt", className)}></i>
}

function GoeAltFillIcon({className, onclick}) {
    return <i onClick={onclick} className={setIcon("geo-alt-fill", className)}></i>
}

function CodeSlashIcon({className, onclick}) {
    return <i onClick={onclick} className={setIcon("code-slash", className)}></i>
}

function TerminalIcon({className, onclick}) {
    return <i onClick={onclick} className={setIcon("terminal", className)}></i>
}

function BookIcon({className, onclick}) {
    return <i onClick={onclick} className={setIcon("book", className)}></i>
}


function PencilSquareIcon({className, onclick}) {
    return <i onClick={onclick} className={setIcon("pencil-square", className)}></i>
}

function CheckSquareIcon({className, onclick}) {
    return <i onClick={onclick} className={setIcon("check2-square", className)}></i>
}

function PenIcon({className, onclick}) {
    return <i onClick={onclick} className={setIcon("pen", className)}></i>
}

function TvIcon({className, onclick}) {
    return <i onClick={onclick} className={setIcon("tv", className)}></i>
}

function TextLeftIcon({className, onclick}) {
    return <i onClick={onclick} className={setIcon("text-left", className)}></i>
}

function MusicNoteIcon({className, onclick}) {
    return <i onClick={onclick} className={setIcon("music-note", className)}></i>
}

function DeleteIcon({className, onclick}) {
    return <i onClick={onclick} className={setIcon("clipboard2-x", className)}></i>
}

function RemoveIcon({className, onclick}) {
    return <i onClick={onclick} className={setIcon("clipboard-minus", className)}></i>
}

function AddIcon({className, onclick}) {
    return <i onClick={onclick} className={setIcon("clipboard-plus", className)}></i>
}

export {
    RoadmapIcon,
    CheckIcon,
    CheckCircleIcon,
    FullScreenIcon,
    FullScreenExitIcon,
    GoeAltIcon,
    GoeAltFillIcon,
    CodeSlashIcon,
    TerminalIcon,
    BookIcon,
    PencilSquareIcon,
    CheckSquareIcon,
    PenIcon,
    TvIcon,
    TextLeftIcon,
    MusicNoteIcon,
    DeleteIcon,
    RemoveIcon,
    AddIcon
}
