import { Route, Routes } from 'react-router-dom';
import './App.css';
import React, { useEffect, useState } from 'react';

import Header from './components/Header';
import Home from './pages/Home';
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
    <Header/>
    <Routes>
      <Route path='/' element={<Home bookList={bookList}/>} />
    </Routes>
    </>
    
    
  );
}

export default App;
