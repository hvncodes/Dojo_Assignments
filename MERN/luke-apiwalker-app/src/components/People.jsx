import React, { useState, useEffect } from 'react';
import { useParams } from "react-router";
import axios from 'axios';

const People = (props) => {
    const { id } = useParams();
    const [person, setPerson] = useState(null);
    const [error, setError] = useState('fetching...');

    useEffect(() => {
        axios.get('https://swapi.dev/api/people/' + id)
            .then(response => {
                console.log(response.data);
                setPerson(response.data);
                setError(null);
            })
            .catch((error) => {
                console.log(error);
                setError(
                // <img src="https://c.tenor.com/8ApsefKQh2gAAAAC/starwars-droids.gif" alt="obiwan kenobi jedi mind tricks gif" />
                // <iframe src="https://c.tenor.com/8ApsefKQh2gAAAAC/starwars-droids.gif" width="600" height="400" frameborder="0"></iframe>
                <p>These aren't the droids you're looking for.</p>
                );
            });
        
    }, [id]);

    const spanStyles = {
        fontWeight: "bold",
    }

    return (
        <>
        {person ?
            <>
            <h2>{ person.name }</h2>
            <p><span style={ spanStyles }>Height: </span>{ person.height } cm</p>
            <p><span style={ spanStyles }>Mass: </span>{ person.mass } kg</p>
            <p><span style={ spanStyles }>Hair Color: </span>{ person.hair_color }</p>
            <p><span style={ spanStyles }>Skin Color: </span>{ person.skin_color }</p>
            </>
            :''
        }
        {error ?
            error
            : ''
        }
        </>
    );
}

export default People;