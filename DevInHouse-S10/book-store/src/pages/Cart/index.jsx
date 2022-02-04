import BookShelf from "../../components/BookShelf";
import { useContext } from "react";
import { CartContext } from "../../context/Cart";

const Cart = () =>{

    const cartShelf = useContext(CartContext);
    console.log(cartShelf.cart);


    if (cartShelf.cart.length == 0) {


        return(
            <>
            <h3>Total: R$0,00</h3>
            </>
        )


    
    } else {


        const sumTotalCart = cartShelf.cart.map((value) => {
            return value.price;
        })


        const returnShelf = cartShelf.cart.map((cartItems, i) => {
        
        return(
        <BookShelf
        key={i}
        cartItem={cartItems}
        />

        )

    })


    return(
        <>
        <h3>Total: R${(sumTotalCart.reduce((a, b) => a+b).toFixed(2))}</h3>
        <div>{returnShelf}</div>
        </>
    )

    console.log('teste')


    }  
    
}

export default Cart;