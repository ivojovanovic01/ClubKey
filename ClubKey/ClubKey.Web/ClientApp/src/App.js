import React from "react";
import { Route, BrowserRouter, Switch, Redirect } from "react-router-dom";
import "./styles/style.css";
import FrontPageView from "./components/FrontPage/frontPageView";
import ClickedEventView from "./components/ClikedEvent/clikedEventView";
import BuyingScreen from "./components/BuyingScreen/buyingScreenView";
import UserAccountView from "./components/userAccount/userAccountView";

function App() {
  return (
    <BrowserRouter>
      <Switch>
        <Route exact path="/" component={FrontPageView} />
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
		<Route
          exact
          path="/user"
          render={props => <UserAccountView {...props} />}
        />
        <Redirect to="/" />
      </Switch>
    </BrowserRouter>
  );
}

export default App;
