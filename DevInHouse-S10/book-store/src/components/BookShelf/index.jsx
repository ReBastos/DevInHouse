
const BookShelf = ({image, title, price}) => {

    return(

    <>
    <div>
        <div>
            <img src={image}></img>
            <h3>{title}</h3>
        </div>
            
        <div>
            <h3>{price}</h3>
            <button>Remover</button>
        </div>
    </div>
    </>

    )

}

export default BookShelf;