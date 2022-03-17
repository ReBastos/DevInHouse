import styled from "styled-components"


const Input = styled.input`

width: 250px;
height: 40px;
border-radius: 3px;
border: 1px solid;
border-color: lightgrey;

:hover {
    zoom: 103%
}

`

const Label = styled.p`

font-weight: bold;
font-size: 18px;
margin: 0;
margin-bottom: 5px;

`

export {Input, Label};