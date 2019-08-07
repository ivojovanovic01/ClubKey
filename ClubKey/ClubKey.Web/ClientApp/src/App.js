import React from "react";
import { Route, BrowserRouter, Switch, Redirect } from "react-router-dom";
import SignUpSignInView from "./components/SignUpSignIn/signUpSignInView";
import "./styles/style.css";

function App() {
  return (
    <BrowserRouter>
      <Switch>
        <Route path="/index" render={props => <SignUpSignInView />} />
        <Redirect to="/index" />
      </Switch>
    </BrowserRouter>
  );
}

export default App;
