import React, { useState, useEffect } from 'react';
import { useParams } from "react-router";
import axios from 'axios';

const Planets = (props) => {
    const { id } = useParams();
    const [planet, setPlanet] = useState(null);

    useEffect(() => {
        axios.get('https://swapi.dev/api/planets/' + id)
            .then(response => {
                console.log(response.data);
                setPlanet(response.data);
            })
            .catch((error) => {
                console.log(error);
            });
    }, [id]);

    const spanStyles = {
        fontWeight: "bold",
    }

    return (
        <>
        {planet ?
            <>
            <h2>{ planet.name }</h2>
            <p><span style={ spanStyles }>Climate: </span>{ planet.climate }</p>
            <p><span style={ spanStyles }>Terrain: </span>{ planet.terrain }</p>
            <p><span style={ spanStyles }>Surface Water: </span>{ planet.surface_water }</p>
            <p><span style={ spanStyles }>Population: </span>{ planet.population }</p>
            </>
            :'fetching...'
        }
        </>
    );
}

export default Planets;