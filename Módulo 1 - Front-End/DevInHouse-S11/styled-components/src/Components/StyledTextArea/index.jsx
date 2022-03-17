import { TextArea } from "./style";
import { Label } from "../Input/style";

const StyledTextArea = ({labelValue}) => {
    return(

        <div>
            <Label>{labelValue}</Label>
            <TextArea/>
        </div>

    )
}

export default StyledTextArea;