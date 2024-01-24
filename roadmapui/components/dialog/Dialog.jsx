import "./dialog.css"
import React, {Fragment, Children} from "react";

export const DialogBody = ({children, type = "form"}) => {
    return <div className="body">
        {children}
    </div>
}

export const DialogFooter = ({children}) => {
    return <div className="footer">
        {children}
    </div>
}

export const DialogForm = ({children}) => {
    return <div className="form">
        {children}
    </div>
}

export const TextInput = ({id, onChange, defaultValue, placeholder, name = id, label = id}) => {
    return <>
        <div className="input-group">
            <label htmlFor={id}>{label}</label>
            <input className="input"
                   type="text" id={id}
                   onChange={onChange} name={name}
                   value={defaultValue}
                   placeholder={placeholder}
                // maxLength={maxLength} minLength={minLength} required={required}
            />
        </div>
    </>
}

export const LongTextInput = ({id, onChange, defaultValue, placeholder, name = id, label = id}) => {
    return <>
        <div className="input-group">
            <label htmlFor={id}>{label}</label>
            <textarea
                className="input long-text" id={id}
                onChange={onChange} name={name}
                value={defaultValue}
                placeholder={placeholder}
                // maxLength={maxLength} minLength={minLength} required={required}
            ></textarea>
        </div>
    </>
}

export const Labeled = ({label, children}) => {
    return <>
        <div className="input-group">
            <label>{label}</label>
            {children}
        </div>
    </>
}

export const DialogButton = ({onClick, label, className, style, icon}) => {
    return <>
        <button
            style={style}
            className={"submit-button " + (className ? className : "")}
            onClick={onClick}>
            {icon}
            {label}
        </button>
    </>
}

export const DialogSection = ({title, description, children}) => {
    return <div className="section">
        <div className="header">
            <h2 className="title">{title}</h2>
            {description && <p className="description">{description}</p>}
        </div>
        {children}
    </div>
}

export default function Dialog({onClose, title, description, divided = false, children}) {
    return <>
        <div className="dialog">
            <div className="overlay" onClick={onClose}></div>
            <div className={"content " + (divided ? "divided" : "")}>
                {!divided ? <>
                    <DialogSection title={title} description={description} children={children}/>
                </> : <>
                    {children}
                </>}
            </div>
        </div>
    </>
}
