import 'bootstrap-icons/font/bootstrap-icons.css'

function setIcon(icon, className) {
    return `bi bi-${icon} ${className}`
}

function Icon({className = "icon", onclick, pointer, name}) {
    return <i style={{cursor: pointer ? "pointer" : "inherit"}} onClick={onclick}
              className={setIcon(name, className)}></i>
}

export const RoadmapIcon = (props) => <Icon {...props} name="map-fill"/>

export const CheckIcon = (props) => <Icon {...props} name="check"/>

export const PlusIcon = (props) => <Icon {...props} name="plus"/>

export const CheckCircleIcon = (props) => <Icon {...props} name="check2-circle"/>

export const FullScreenIcon = (props) => <Icon {...props} name="fullscreen"/>

export const FullScreenExitIcon = (props) => <Icon {...props} name="fullscreen-exit"/>

export const GoeAltIcon = (props) => <Icon {...props} name="geo-alt"/>

export const GoeAltFillIcon = (props) => <Icon {...props} name="geo-alt-fill"/>

export const CodeSlashIcon = (props) => <Icon {...props} name="code-slash"/>

export const TerminalIcon = (props) => <Icon {...props} name="terminal"/>

export const BookIcon = (props) => <Icon {...props} name="book"/>

export const PencilSquareIcon = (props) => <Icon {...props} name="pencil-square"/>

export const CheckSquareIcon = (props) => <Icon {...props} name="check2-square"/>

export const PenIcon = (props) => <Icon {...props} name="pen"/>

export const TvIcon = (props) => <Icon {...props} name="tv"/>

export const TextLeftIcon = (props) => <Icon {...props} name="text-left"/>

export const MusicNoteIcon = (props) => <Icon {...props} name="music-note"/>

export const DeleteIcon = (props) => <Icon {...props} name="clipboard2-x"/>

export const RemoveIcon = (props) => <Icon {...props} name="clipboard-minus"/>

export const AddIcon = (props) => <Icon {...props} name="clipboard-plus"/>

export const LookIcon = (props) => <Icon {...props} name="bookmark-fill"/>

export const UserIcon = (props) => <Icon {...props} name="person-circle"/>

export const SearchIcon = (props) => <Icon {...props} name="search"/>

export const HomeIcon = (props) => <Icon {...props} name="house"/>

export const GearIcon = (props) => <Icon {...props} name="gear"/>

export const ClockIcon = (props) => <Icon {...props} name="clock-history"/>
