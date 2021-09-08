import './App.css';
import react, { useState } from 'react';
import BoxForm from './components/BoxForm';
import BoxDisplay from './components/BoxDisplay';

function App() {
  const [currentOutput, setCurrentOutput] = useState([]);
    
  const updateOutput = ( newBox ) => {
    setCurrentOutput( [...currentOutput, newBox] );
  }

  return (
    <div className="App">
      <BoxForm box={ updateOutput } />

      {currentOutput.map((b, i) => {
        return (
          <BoxDisplay id={i} box={b} />
        );
      })}
    </div>
  );
}

export default App;
