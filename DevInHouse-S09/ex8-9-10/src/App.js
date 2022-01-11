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
  const [selector, setSelector] = useState(0);
  useEffect(async () => {

    const response = await fetch('https://swapi.dev/api/people/1/');
    const character = await response.json();
    console.log(character)
    setStarWarsCharcter(character);
    console.log(starWarsCharacter);


  },[])
  // useEffect para alterar título

  // useEffect para alterar personagem

  return (
    <div>
      <Header />
      <SeletorPersonagem valor={0} onChange={() => {}} />
      <Personagem
        nome={starWarsCharacter.name}
        nascimento={starWarsCharacter.birth_year}
        genero={starWarsCharacter.gender}
        peso={starWarsCharacter.mass}
        altura={starWarsCharacter.height}
        corOlhos={starWarsCharacter.eye_color}
        corCabelo={starWarsCharacter.hair}
      />
    </div>
  );
}

export default App;
