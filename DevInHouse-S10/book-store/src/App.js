import { Route, Routes } from 'react-router-dom';
import './App.css';
import React, { useEffect, useState } from 'react';
import { useContext } from 'react';
import { CartProvider } from './context/Cart';

import Header from './components/Header';
import Home from './pages/Home';
import BookDetails from './pages/BookDetails';
import Cart from './pages/Cart';


function App() {

  const [bookList, setbookList] = useState(null);
  
  useEffect( async () => {

    const responseBooks = await fetch('http://localhost:3333/books');
    const books = await responseBooks.json();
    setbookList(books);
    console.log(books)

  } ,[]);

  return (
    <>
    <CartProvider>
    <Header/>
    <Routes>
      <Route path='/' element={<Home bookList={bookList}/>} />
      <Route path='/details' element={<BookDetails />} />
      <Route path='/cart' element={<Cart/>} />
    </Routes>
    </CartProvider>
    </>
    
    
  );
}

export default App;
