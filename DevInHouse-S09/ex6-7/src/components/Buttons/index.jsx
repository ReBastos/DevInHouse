const Buttons = ({countNumber, setCountNumber}) => {

    
    const more = () => {
            setCountNumber(countNumber + 1)
    }

    const less = () => {
        setCountNumber(countNumber - 1)
    }

    return (

        

        <>
        <button onClick={more}>+</button>
        <button onClick={less}>-</button>
        </>

    )
}

export default Buttons;