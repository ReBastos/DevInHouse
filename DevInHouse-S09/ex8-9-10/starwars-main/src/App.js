import "./App.css";
import React from "react";
import Personagem from "./components/Personagem";
import SeletorPersonagem from "./components/SeletorPersonagem";
import Header from "./components/Header";

const estado_inicial = {
  name: "",
  birth_year: "",
  gender: "",
  mass: "",
  height: "",
  eye_color: "",
  hair_color: "",
};

function App() {
  // useState

  // useEffect para alterar título

  // useEffect para alterar personagem

  return (
    <div>
      <Header />
      <SeletorPersonagem valor={0} onChange={() => {}} />
      <Personagem
        nome={"?"}
        nascimento={"?"}
        genero={"?"}
        peso={"?"}
        altura={"?"}
        corOlhos={"?"}
        corCabelo={"?"}
      />
    </div>
  );
}

export default App;
