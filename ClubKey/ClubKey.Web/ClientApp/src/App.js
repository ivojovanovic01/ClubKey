import React from "react";
import { Route, BrowserRouter, Switch, Redirect } from "react-router-dom";
import MyAccountUserView from "./components/MyAccountUser/myAccountUserView";
import "./styles/style.css";

function App() {
  return (
    <BrowserRouter>
      <Switch>
        <Route path="/index" render={props => <MyAccountUserView />} />
        <Redirect to="/index" />
      </Switch>
    </BrowserRouter>
  );
}

export default App;
