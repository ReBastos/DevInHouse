import { createContext, useState } from "react";
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
    
    return (
        <CartContext.Provider value={{
            cart: cart,
            addItem: handleAddCart
            }}>
            {children}
        </CartContext.Provider>
        
    )
}