import React from "react";
import './index.css'
import { Link } from 'react-router-dom';
import BookCard from "../../components/BookCard";
import { useContext } from "react";
import { CartContext } from "../../context/Cart";

const Home = ({bookList}) => {


    const bookListfinal = bookList;

    if(bookList === null) {

        return (null)
        
    } else {

        const returnBook = bookList.map((livro, i) => {
            return(
                <>
            <BookCard
            key={i}
            bookInfo={bookListfinal[i]}
            />
            </>
            )
        })

        return(

        <div className="home">{returnBook}</div>

        )

        
    }
}

export default Home;