import React, { useState } from 'react';
import { useHistory } from "react-router-dom";

const Form = (props) => {
    const [resource, setResource] = useState("");
    const [id, setId] = useState("");
    const history = useHistory();

    const handleForm = (e) => {
        e.preventDefault();
        history.push("/" + resource + '/' + id);
    }
    
    return (
        <form onSubmit={ handleForm }>
            <label>Search for: </label>
            <select onChange={ (e) => setResource(e.target.value) }>
                <option value="people">People</option>
                <option value="planets">Planets</option>
            </select>
            <label>ID: </label>
            <input type="text" onChange={ (e) => setId(e.target.value) } />
            <input type="submit" value="Search" />
        </form>
    )
}

export default Form;