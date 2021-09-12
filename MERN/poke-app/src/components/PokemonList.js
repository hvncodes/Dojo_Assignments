import React, { useState, useEffect, useLayoutEffect } from 'react';

const PokemonList = (props) => {
    const [pokemons, setPokemons] = useState([]);

    useEffect(() => {
        fetch('https://pokeapi.co/api/v2/pokemon?limit=807')
            .then(response => response.json())
            .then(response => setPokemons(response.results))
    }, []);

    return (
        <div>
            {pokemons.length > 0 ? 
                <ul>
                    {
                        pokemons.length > 0 && pokemons.map((mon, index)=>{
                            return (
                                <li key={index}>{mon.name}</li>
                            );
                        })
                    }
                </ul>
                :
                ''
            }
        </div>
    );
}
export default PokemonList;