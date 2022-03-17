import StyledInput from './Components/Input/Input';
import StyledSelect from './Components/StyledSelect';
import StyledTextArea from './Components/StyledTextArea';
import StyledRadio from './Components/RadioInput';
import './App.css';

function App() {
  return (
    <>
    <StyledInput
    labelValue={"Label Value"}
    />

    <StyledSelect
    labelValue={"Select Value"}
    
    />

    <StyledTextArea
    labelValue={"TextArea Value"}
    />

    <StyledRadio
    labelValue={"Radio"}
    />



    </>
  );
}

export default App;
