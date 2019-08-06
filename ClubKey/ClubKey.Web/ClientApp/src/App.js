import React from "react";
import { Route, BrowserRouter, Switch, Redirect } from "react-router-dom";
import UserAccountView from "./components/userAccount/userAccountView";
import "./styles/style.css";

function App() {
  return (
    <BrowserRouter>
      <Switch>
        <Route path="/index" render={props => <UserAccountView />} />
        <Redirect to="/index" />
      </Switch>
    </BrowserRouter>
  );
}

export default App;
