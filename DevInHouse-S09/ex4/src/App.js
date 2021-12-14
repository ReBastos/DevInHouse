import "./App.css";
import { useState } from "react";
import Lampada from "./components/lampada";

function App() {
  const [aceso, setAceso] = useState(0);
  const [nameButton, setNameButton] = useState("Acender");

  const valorAceso = "0px 0px 70px yellow, inset 0 0 50px orange";
  const valorApagado = "0px 0px 0px yellow";
  return (
    <div id="container">
      <Lampada luz={aceso} />

      <button
        onClick={() => {
          if (aceso == valorAceso) {
            setAceso(valorApagado);
            setNameButton("Acender");
          } else {
            setAceso(valorAceso);
            setNameButton("Apagar");
          }
        }}
      >
        {nameButton}
      </button>
    </div>
  );
}

export default App;
