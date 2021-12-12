import './style.css';


const Post = ({
    profile, 
    name, 
    description,
    image,
    text
}) => {

    return(
        <>
        <div className='post'>
            <div className="profile">
            <img src={profile}></img>
            <div>
            <p id='nome'>{name}</p>
            <p id='descricao'>{description}</p>
            </div>
            </div>

            <p>{text}</p>

            <img src={image} id='imagem'></img>
        </div>
        </>
    )

}

export default Post;