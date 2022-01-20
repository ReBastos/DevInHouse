import './index.css'
import { useContext } from 'react'
import { CartContext } from '../../context/Cart'


const BookCard = ({bookInfo}) => {

    const contextoteste = useContext(CartContext);

    return (

        <>
        <div className='bookCard'>
            <img src={bookInfo.image}></img>
            <h3>{bookInfo.title}</h3>
            <p>R${bookInfo.price}</p>
            <button onClick={() => {
                contextoteste.addItem(bookInfo)
            }}>Comprar</button>
            <button>Detalhes</button>
        </div>
        </>
    )
}

export default BookCard;