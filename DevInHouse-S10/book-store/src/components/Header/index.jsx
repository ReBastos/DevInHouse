import './index.css'
import { useContext } from 'react';
import { CartContext } from '../../context/Cart'

const Header = () => {

    const cartCount = useContext(CartContext);

    return(
        <div id="header">
            <h1>House do Código</h1>
            <p>{cartCount.cart.length} Produtos</p>
        </div>
    )
}

export default Header;