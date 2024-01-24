import "./card-labeled-with-icons.css"

export default function CardLabeledWithIcons({label, icons}) {
    return <>
        <div className="card-labeled-with-icons">
            <span className="label">{label}</span>
            <div className="icons">
                {icons}
            </div>
        </div>
    </>
}
