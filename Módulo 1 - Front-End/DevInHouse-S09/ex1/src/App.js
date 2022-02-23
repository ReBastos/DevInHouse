
import './App.css';
import {useState} from 'react'

function App() {

  const [nome, setNome] = useState('Maria');
  const [cidade, setCidade] = useState('Salvador');
  const [idade, setIdade] = useState(15);
  const [filme, setFilme] = useState('O diabo Veste Prada');

  console.log(nome, cidade, idade, filme);

  return (
    <>
    <p>Meu nome é {nome}, eu moro em {cidade}, tenho {idade} anos e o meu filme preferido é {filme}.</p>
    <button onClick={() => {
      setNome('Renato')
      setCidade('Santo Amaro')
      setIdade(25)
      setFilme('Midsommar')
    }}>Alterar Texto</button>
    <button onClick={() => {
      setFilme('Crash')
    }}>Alterar Filme</button>
    </>
  );
}

export default App;
