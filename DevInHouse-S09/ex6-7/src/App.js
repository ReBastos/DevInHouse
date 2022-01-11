import { useEffect, useState } from 'react';
import './App.css';
import Buttons from './components/Buttons';

function App() {

  const [countNumber, setCountNumber] =  useState(0);

  useEffect( () => {
    if (countNumber < 0){
      alert('O número não pode ser negativo');
      setCountNumber(0);
    } else if (countNumber == 20){
      alert('Número máximo atingido! Resetando…');
      setCountNumber(0);
    }
  } ,[countNumber])

  return (
    <>
    <h1>O número atula é: {countNumber}</h1>
    <Buttons
    countNumber={countNumber}
    setCountNumber={setCountNumber}
    />
    </>
  );
}

export default App;
