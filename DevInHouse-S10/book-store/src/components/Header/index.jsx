import './index.css'
import { useContext } from 'react';
import { CartContext } from '../../context/Cart'
import { Link } from 'react-router-dom';

const Header = () => {

    const cartCount = useContext(CartContext);

    return(
        <div id="header">
            <Link to={'/'}><h1>House do Código</h1></Link>
            <Link to={'/cart'}><p>{cartCount.cart.length} Produtos</p></Link>
        </div>
    )
}

export default Header;