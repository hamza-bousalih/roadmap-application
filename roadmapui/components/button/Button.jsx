import "./button.css"


const ButtonStyle = {
    background: 'var(--purpal)' ,
    padding: '10px 20px' ,
    borderRadius: '7px' ,
    color: 'var(--form-field-bg)' ,
    fontWeight: '600' ,
    fontSize: '16px'
}

export default function Button({label , className , styles , onClick}) {
    return <button className={className} style={{...ButtonStyle, ...styles}} onClick={onClick}>{label}</button>
}
