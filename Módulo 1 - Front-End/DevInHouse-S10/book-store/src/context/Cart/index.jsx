import { createContext, useEffect, useState } from "react";
import { v4 as uuidv4 } from 'uuid';

export const CartContext = createContext([]);

export const CartProvider = ({children}) => {

    const [cart, setCart] = useState([]);


    const handleAddCart = (item) => {

        const newBook ={
            ...item,
            idCard: uuidv4()
        }
            setCart([...cart, newBook]);
            
    }

    const handRemoveItem = (idBook) => {
        const booksFiltered = cart.filter((book) => {

            if (book.idCard === idBook) {
                return false
            } else {
                return true
            }
    
        })

        setCart(booksFiltered);

    }
    
    return (
        <CartContext.Provider value={{
            cart: cart,
            addItem: handleAddCart,
            removeItem: handRemoveItem
            }}>
            {children}
        </CartContext.Provider>
        
    )
}