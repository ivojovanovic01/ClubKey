import React from "react";
import { Route, BrowserRouter, Switch, Redirect } from "react-router-dom";
import "./styles/style.css";
import FrontPageView from "./components/FrontPage/frontPageView";
import ClickedEventView from "./components/ClikedEvent/clikedEventView";
import BuyingScreen from "./components/BuyingScreen/buyingScreenView";

function App() {
  return (
    <BrowserRouter>
      <Switch>
        <Route exact path="/events" component={FrontPageView} />
        <Route
          exact
          path="/events/:id"
          render={props => <ClickedEventView {...props} />}
        />
        <Route
          exact
          path="/buy-ticket/:id"
          render={props => <BuyingScreen {...props} />}
        />
        <Redirect to="/" />
      </Switch>
    </BrowserRouter>
  );
}

export default App;
