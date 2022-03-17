import { Input, Label } from "./style";

const StyledInput = ({labelValue, ...otherProps}) => {

    return (
        <div>
            <Label>{labelValue}</Label>
            <Input {...otherProps}></Input>

        </div>
    )

}

export default StyledInput;