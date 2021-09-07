import './App.css';
import react, { useState } from 'react';
import BoxForm from './components/BoxForm';
import BoxDisplay from './components/BoxDisplay';

function App() {
  const [currentOutput, setCurrentOutput] = useState([]);
    
  const updateOutput = ( newBox ) => {
    // setCurrentOutput( newBox, ...currentOutput );
    setCurrentOutput( newBox, ...currentOutput );
  }

  return (
    <div className="App">
      <BoxForm box={ updateOutput } />

      {currentOutput.map((b) => {
        return (
          <BoxDisplay box={b} />
        );
      })}
    </div>
  );
}

export default App;
