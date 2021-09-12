import React, { useState, useEffect } from 'react';
import axios from 'axios';

const PokemonList = (props) => {
    const [pokemons, setPokemons] = useState(null);

    useEffect(() => {
        axios.get('https://pokeapi.co/api/v2/pokemon?limit=807')
            .then(response => {
                console.log(response.data);
                setPokemons(response.data.results);
            })
    }, []);
    function formatPokeName(str) {
        let words = str.split('-');
        for (var i = 0; i < words.length; i++) {
            words[i] = words[i].charAt(0).toUpperCase() + words[i].slice(1);
        }
        return words.join(' ');
    }
    return (
        <div>
            {pokemons ? 
                <ul>
                    {
                        pokemons.length > 0 && pokemons.map((mon, index)=>{
                            return (
                                <li key={index}>{formatPokeName(mon.name)}</li>
                            );
                        })
                    }
                </ul>
                :
                'fetching...'
            }
        </div>
    );
}
export default PokemonList;