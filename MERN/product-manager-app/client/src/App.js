import React from "react";
import { Link, Redirect, Route, Switch } from "react-router-dom";
import "./App.css";
import Main from "./views/Main";
import Products from "./views/Products";
import Product from "./views/Product";

function App() {
  return (
    <div className="App">
      <Switch>
        <Redirect exact from="/" to="/products" />
        {/* <Route exact path="/">
          <Main />
        </Route> */}

        <Route exact path="/products">
          <Main />
          <Products />
        </Route>

        <Route exact path="/products/:id">
          <Product />
        </Route>
      </Switch>
    </div>
  );
}

export default App;
