import { Radio } from "./style";
import { Label } from "../Input/style";


const StyledRadio = ({labelValue}) =>{

    return(
        <div>
            <label><Radio type={"radio"}/>{labelValue}</label>
        </div>
    )
}

export default StyledRadio;