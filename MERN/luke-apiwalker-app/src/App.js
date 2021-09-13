import './App.css';
import React from "react";
import {
  BrowserRouter,
  Switch,
  Route,
  Link 
} from "react-router-dom";
import Home from './components/Home';
import People from './components/People';
import Planets from './components/Planets';
import Form from './components/Form';

function App() {
  return (
    <BrowserRouter>

      <p>
        <Link to="/">Home</Link>
        &nbsp;|&nbsp;
        <Link to="/people/1">Peoples ID: 1</Link>
        &nbsp;|&nbsp;
        <Link to="/planets/5">Planets ID: 5</Link>
      </p>

      <hr />

      <Form />

      <Switch>
        <Route exact path="/people/:id">
          <People />
        </Route>

        <Route exact path="/planets/:id">
          <Planets />
        </Route>

        <Route exact path="/">
          <Home />
        </Route>
      </Switch>

    </BrowserRouter>
  );
}

export default App;
