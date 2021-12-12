import './style.css'

const Product = ({
    productPic,
    productName,
    productPrice
}) => {
    return(
        <div className="product">
            <img src={productPic}></img>
            <h3>{productName}</h3>
            <p>{productPrice}</p>
            <p></p>
        </div>
    );
}

export default Product;