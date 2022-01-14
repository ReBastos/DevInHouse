import { Route, Routes } from 'react-router-dom';
import './App.css';
import React, { useEffect } from 'react';


import Home from './pages/Home';
import Cart from './pages/Cart';


function App() {

  
  useEffect( async() => {

    const responseBooks = await fetch('http://localhost:3333/books');
    const books = await responseBooks.json();

    console.log(books);
  } ,[]);

  return (
    <>
    <h1>Teste</h1>
    <Routes>
      <Route path='/' element={<Home/>} />
      <Route path='/cart' element={<Cart/>} />
    </Routes>
    </>
    
    
  );
}

export default App;
