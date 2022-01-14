import { Route, Routes } from 'react-router-dom';
import './App.css';
import React from 'react';


import Home from './pages/Home';
import Cart from './pages/Cart';


function App() {
  return (
    <>
    <h1>Teste</h1>
    <Routes>
      <Route path='/' element={<Home/>} />
      </Routes>
    </>
    
    
  );
}

export default App;
