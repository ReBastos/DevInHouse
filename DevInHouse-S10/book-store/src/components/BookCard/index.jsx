import './index.css'

const BookCard = ({image, title, price}) => {


    return (

        <>
        <div className='bookCard'>

            <img src={image}></img>
            <h3>{title}</h3>
            <p>R${price}</p>
            <button>Comprar</button>
            <button>Detalhes</button>
        </div>
        </>
    )
}

export default BookCard;