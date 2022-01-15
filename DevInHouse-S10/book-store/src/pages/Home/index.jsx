import React from "react";
import './index.css'
import { Link } from 'react-router-dom';
import BookCard from "../../components/BookCard";

const Home = ({bookList}) => {

    if(bookList === null) {

        return (null)
        
    } else {

        const returnBook = bookList.map((livro, i) => {
            return(
            <BookCard
            key={i}
            image={livro.image}
            title={livro.title}
            price={livro.price}
            />
            )
        })

        return(

        <div className="home">{returnBook}</div>

        )

        
    }
}

export default Home;