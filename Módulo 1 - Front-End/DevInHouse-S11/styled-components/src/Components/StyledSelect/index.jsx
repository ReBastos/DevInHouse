import { Select } from "./style";
import { Label } from "../Input/style";

const StyledSelect = ({labelValue, ...otherProps}) => {
    return (

        <div>
            <Label>{labelValue}</Label>
            <Select {...otherProps}></Select>

        </div>
    )
}

export default StyledSelect;