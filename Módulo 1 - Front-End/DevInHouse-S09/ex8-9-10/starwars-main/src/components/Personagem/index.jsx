import PropType from "prop-types";
import "./styles.css";

function Personagem({
  nome,
  nascimento,
  genero,
  peso,
  altura,
  corOlhos,
  corCabelo
}) {
  return (
    <div className="content">
      <div className="card">
        <h2>{nome}</h2>
        <hr />
        <div className="person-data">
          <p>
            Ano de nascimento: <span>{nascimento}</span>
          </p>
          <p>
            Sexo: <span>{genero}</span>
          </p>
          <p>
            Peso (kg): <span>{peso}</span>
          </p>
          <p>
            Altura (cm): <span>{altura}</span>
          </p>
          <p>
            Cor dos olhos: <span>{corOlhos}</span>
          </p>
          <p>
            Cor do cabelo: <span>{corCabelo}</span>
          </p>
        </div>
      </div>
    </div>
  );
}

Personagem.propTypes = {
  nome: PropType.string,
  nascimento: PropType.string,
  genero: PropType.string,
  peso: PropType.string,
  altura: PropType.string,
  corOlhos: PropType.string,
  corCabelo: PropType.string,
};

export default Personagem;