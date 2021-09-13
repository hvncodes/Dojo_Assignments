import './App.css';
import React from "react";
import {
  BrowserRouter,
  Switch,
  Route,
  Link 
} from "react-router-dom";
import Home from './components/Home';
import Word from './components/Word';

function App() {
  return (
    <BrowserRouter>

      <h1>Routing Example</h1>
      <p>
        <Link to="/">Home</Link>
        &nbsp;|&nbsp;
        <Link to="/banana">Banana</Link>
        &nbsp;|&nbsp;
        <Link to="/42">42</Link>
        &nbsp;|&nbsp;
        <Link to="/watermelon/black/pink">Watermelon</Link>
      </p>

      <Switch>
        <Route path="/:word/:textColor/:bgColor">
          <Word />
        </Route>
        
        <Route path="/:word">
          <Word />
        </Route>

        <Route exact path="/">
          <Home />
        </Route>
      </Switch>

    </BrowserRouter>
  );
}

export default App;
