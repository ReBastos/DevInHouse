import BookShelf from "../../components/BookShelf";
import { useContext } from "react";
import { CartContext } from "../../context/Cart";

const Cart = () =>{

    const cartShelf = useContext(CartContext);


    if (cartShelf != null) {

        const returnShelf = cartShelf.cart.map((cartItems, i) => {
        return(
        <BookShelf
        key={i}
        cartItem={cartItems}
        />

        )

    })

    return(
        <div>{returnShelf}</div>
    )
    } else {
        return(null)
    }
    return(
        <>
        <BookShelf
        image={'https://cdn.shopify.com/s/files/1/0155/7645/products/OretornodocangaceiroJavaScript_ebook_large.jpg?v=1631654115'}
        title={'JavaScript'}
        price={'R$40,00'}
        />
        
        </>
    )
}

export default Cart;