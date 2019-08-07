import React, { Component } from "react";
import { Link } from "react-router";
import SignIn from "./signIn";
import SignUp from "./signUp";
import "../../styles/style_login.css";
import {} from "./apiRequests";

class SignUpSignInView extends Component {
  state = {
    isLogin: false
  };

  componentDidMount = () => {
    this.setState({ isLogin: this.props.isLogin });
  };

  handleChangeToSignInPage = () => {
    this.setState({ isLogin: true });
  };

  handleChangeToSignUpPage = () => {
    this.setState({ isLogin: false });
  };

  handleSignIn = () => {};

  handleSignUp = () => {};

  render() {
    const { isLogin } = this.state;
    return (
      <div>
        {isLogin ? (
          <SignIn
            signIn={this.handleSignIn}
            changeToSignUpPage={this.handleChangeToSignUpPage}
          />
        ) : (
          <SignUp
            signUp={this.handleSignUp}
            changeToSignInPage={this.handleChangeToSignInPage}
          />
        )}
      </div>
    );
  }
}

export default SignUpSignInView;
