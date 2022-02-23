import "./App.css";
import React, { useEffect, useState } from "react";
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
  const [starWarsCharacter, setStarWarsCharcter] = useState(estado_inicial);
  const [selector, setSelector] = useState(1);

  useEffect(async () => {

    const response = await fetch(`https://swapi.dev/api/people/${selector}/`);
    const character = await response.json();
    console.log(character)
    setStarWarsCharcter(character);
    console.log(starWarsCharacter);


  },[selector])
  // useEffect para alterar título

  // useEffect para alterar personagem

  return (
    <div>
      <Header />
      <SeletorPersonagem valor={selector} onChange={(evt) => {
        setSelector(evt.target.value);
      }} />
      <Personagem
        dados={starWarsCharacter}
      />
    </div>
  );
}

export default App;
