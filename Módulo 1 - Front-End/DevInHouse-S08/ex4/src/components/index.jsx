import './style.css'

const Button = ({bg,text}) => {
    return(
        <button style={{background: bg}}>{text}</button>
    )

}

export default Button;