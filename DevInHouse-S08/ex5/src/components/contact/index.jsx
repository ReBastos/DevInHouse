import './style.css'

const Contact = ({photo, name, description}) =>{
    return(
        <>
        <div className='contact'>
            <img src={photo} id='profilePic'></img>
            <div>
            <p id='nome'>{name}</p>
            <p id='descricao'>{description}</p>
            </div>
        </div>
        </>
    )
} 

export default Contact;