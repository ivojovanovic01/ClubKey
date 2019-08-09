import React from "react";
import { Route, BrowserRouter, Switch, Redirect } from "react-router-dom";
import "./styles/style.css";
import FrontPageView from "./components/frontPage/frontPageView";
import ClickedEventView from "./components/clikedEvent/clikedEventView";
import BuyingScreenView from "./components/buyingScreen/buyingScreenView";

function App() {
  return (
    <BrowserRouter>
      <Switch>
        <Route path="/index" render={props => <FrontPageView />} />
        <Redirect to="/index" />
      </Switch>
    </BrowserRouter>
  );
}

export default App;
