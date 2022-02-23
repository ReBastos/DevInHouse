import './index.css'
import { useContext } from "react";
import { CartContext } from "../../context/Cart";

const BookShelf = ({cartItem}) => {

    const shelfContext = useContext(CartContext); 



    return(

    <>
    <div className='BookShelf'>
        <div>
            <img src={cartItem.image}></img>
            <h3>{cartItem.title}</h3>
        </div>
            
        <div>
            <h3>R${(cartItem.price).toFixed(2)}</h3>
            <button onClick={() => {
                shelfContext.removeItem(cartItem.idCard);
            }}>Remover</button>
        </div>
    </div>
    </>

    )

}

export default BookShelf;