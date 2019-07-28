import React from "react";
import { Route, BrowserRouter, Switch, Redirect } from "react-router-dom";
import FrontPage from "./components/FrontPage/frontPage";

function App() {
  return (
    <BrowserRouter>
      <Switch>
        <Route path="/index" render={props => <FrontPage />} />
        <Redirect to="/index" />
      </Switch>
    </BrowserRouter>
  );
}

export default App;
