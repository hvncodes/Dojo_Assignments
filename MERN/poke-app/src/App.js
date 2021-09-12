import React, { useState } from 'react';
import './App.css';
import PokemonList from './components/PokemonList';
// https://reactjs.org/docs/conditional-rendering.html
function App() {
  const [showList, setShowList] = useState(false);

  const handleShowList = (e) => {
    setShowList(true);
  }
  return (
    <div className="App">
      <button onClick={ handleShowList }>Fetch Pokemon</button>
      {
        showList ? <PokemonList /> : ''
      }
    </div>
  );
}

export default App;
