import "./App.css";
import { useState } from "react";
import Lampada from "./components/lampada";

function App() {
  const [aceso, setAceso] = useState(0);
  const [nameButton, setNameButton] = useState("Acender");
  return (
    <div id="container">
      <Lampada luz={aceso} />

      <button
        onClick={() => {
          if (aceso == "0px 0px 50px yellow") {
            setAceso("0px 0px 0px yellow");
            setNameButton("Acender");
          } else {
            setAceso("0px 0px 50px yellow");
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
