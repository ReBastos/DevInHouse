import './App.css';
import Pokemon from './components/Pokemon';

function App() {
  return(
    <>
    <h1 className='title'>PokeDex</h1>
    <Pokemon
    photo='https://i.pinimg.com/originals/96/d2/1d/96d21d738561947f96255e6f12f1754a.png'
    name='Bulbasaur'
    hp={100}
    attack={100}
    defense={100}
    types={['grass', 'fire', 'water']}
    />
    
    </>
  )
}

export default App;
