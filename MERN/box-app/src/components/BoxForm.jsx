import react, { useState } from 'react';

const BoxForm = (props) => {
    const [color, setColor] = useState("");
    const [size, setSize] = useState("");

    const handleSubmit = (e) => {
        e.preventDefault();
        let newBox = {};
        // setSize(100); // does not work
        if (size.length === 0 ) {
            console.log("Defaulting to Size 100px");
            newBox = {
                size: 100,
                color: color
            };
        } else {
            newBox = {
                size: size,
                color: color
            };
        }
        props.box(newBox);
        setColor("");
        setSize("");
    };

    return (
        <form onSubmit={ handleSubmit }>
            <label>Color </label> 
            <input type="text" value={ color } onChange={ (e) => setColor(e.target.value) }/>
            <label>Size (px) </label> 
            <input type="text" placeholder="100" value={ size } onChange={ (e) => setSize(e.target.value) }/>
            <button type="submit">Add</button>
        </form>
    )
}

export default BoxForm;