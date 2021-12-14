
import './App.css';
import {useState} from 'react'

function App() {

  const [aceso, setAceso] = useState(true)
  return (
    <div
      style={{
        width: "100%",
        height: "500px",
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
        backgroundColor: aceso ? "#ffee00" : "#000",
      }}
    >
      <button onClick={() => {
        aceso ? setAceso(false) : setAceso(true)
      }}>Mudar</button>
    </div>
  );
}

export default App;
