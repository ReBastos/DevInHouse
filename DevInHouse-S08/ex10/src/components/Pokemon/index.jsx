const Pokemon = ({
  photo, 
  name,
  hp,
  attack,
  defense,
  types
}) => {

    return(
    <>
    <div className='pokemon' /* style={{background: typeColor}} */>
      <img className='pokemonImage' src={photo} alt={name}></img>

      <h2>{name}</h2>

      <ul className='pokemonInfo'>
        <li>HP: {hp}</li>
        <li>Attack: {attack}</li>
        <li>Defense: {defense}</li>
      </ul>

      <div>
        {types.join(' / ')}
      </div>
    </div>
    </>
    )
}

export default Pokemon;