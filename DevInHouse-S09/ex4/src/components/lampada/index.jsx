import lampada from './lampada.png'

const Lampada = ({luz}) => {

    return (
        <img src={lampada} 
        style={{boxShadow: luz, borderRadius: '50%', width: '100px', height: '100px'}}>
        </img>
    )

}

export default Lampada;