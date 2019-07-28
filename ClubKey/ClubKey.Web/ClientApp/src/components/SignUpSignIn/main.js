import React, { Component } from "react";
import { Link } from "react-router";
import SignIn from "./signIn";
import SignUp from "./signUp";
import {} from "./apiRequests";

class Main extends Component {
  state = {
    isLogin: true
  };

  componentDidMount = () => {
    this.setState({ isLogin: this.props.isLogin });
  };

  isLoginPage = () => {
    this.setState({ isLogin: true });
  };

  isSignUpPage = () => {
    this.setState({ isLogin: false });
  };

  render() {
    const { isLogin } = this.state;
    return (
      <div>
        {isLogin ? (
          <SignIn handleIsLoginPage={this.isLoginPage} />
        ) : (
          <SignUp handleIsSignUpPage={this.isSignUpPage} />
        )}
      </div>
    );
  }
}

export default Main;
