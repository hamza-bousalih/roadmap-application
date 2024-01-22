import "./dialog.css"
import {button} from "@nextui-org/react";

const DialogBody = ({children}) => {
    return <div className="body">
        {children}
    </div>
}

const DialogFooter = ({children}) => {
    return <div className="footer">
        {children}
    </div>
}

const TextInput = (
    {
        id, onChange, defaultValue, placeholder,
        name = id, label = id
        // options: {maxLength, minLength, required}
    }) => {
    return <>
        <div className="input-group">
            <label htmlFor={id}>{label}</label>
            <input className="input"
                   type="text" id={id}
                   onChange={onChange} name={name}
                   defaultValue={defaultValue}
                   placeholder={placeholder}
                // maxLength={maxLength} minLength={minLength} required={required}
            />
        </div>
    </>
}

const LongTextInput = (
    {
        id, onChange, defaultValue, placeholder,
        name = id, label = id
        // options: {maxLength, minLength, required}
    }) => {
    return <>
        <div className="input-group">
            <label htmlFor={id}>{label}</label>
            <textarea
                className="input long-text" id={id}
                onChange={onChange} name={name}
                defaultValue={defaultValue}
                placeholder={placeholder}
                // maxLength={maxLength} minLength={minLength} required={required}
            ></textarea>
        </div>
    </>
}

const SubmitButton = ({onClick, label}) => {
    return <button
        className="submit-button"
        onClick={onClick}
    >{label}</button>
}

export default function Dialog({onClose, title, description, children}) {
    return <>
        <div className="dialog">
            <div className="overlay" onClick={onClose}></div>
            <div className="content">
                <div className="header">
                    <h2 className="title">{title}</h2>
                    {description && <p className="description">{description}</p>}
                </div>
                {children}
            </div>
        </div>
    </>
}

export {DialogBody, DialogFooter}
export {TextInput, LongTextInput, SubmitButton}
