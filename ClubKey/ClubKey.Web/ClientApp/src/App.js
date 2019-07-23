import React from "react";
import { Route, BrowserRouter, Switch, Redirect } from "react-router-dom";
import Index from "./components/FrontPage/index";

function App() {
  return (
    <BrowserRouter>
      <Switch>
        <Route path="/index" render={props => <Index />} />
        <Redirect to="/index" />
      </Switch>
    </BrowserRouter>
  );
}

export default App;
