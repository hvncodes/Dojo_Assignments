import react, { useState } from 'react';

const BoxForm = (props) => {
    const [color, setColor] = useState("");
    const [size, setSize] = useState(100);

    const handleSubmit = (e) => {
        e.preventDefault();
        const newBox = {
            size: size,
            color: color
        };
        props.box(newBox);
        setColor("");
        setSize(100);
    };

    return (
        <form onSubmit={ handleSubmit }>
            <label>Color </label> 
            <input type="text" onChange={ (e) => setColor(e.target.value) }/>
            <label>Size (px) </label> 
            <input type="text" placeholder="100" onChange={ (e) => setSize(e.target.value) }/>
            <input type="submit" value="Add" />
        </form>
    )
}

export default BoxForm;