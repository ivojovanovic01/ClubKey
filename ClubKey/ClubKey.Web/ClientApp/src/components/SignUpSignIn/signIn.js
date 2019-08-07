import React from "react";
import { Link } from "react-router";

const SignIn = props => {
  return (
    <div>
      <section className="social-networks-login">
        <a className="login-button">
          <img src="./fbIcon.png" alt="" className="login-button--img" />
        </a>
        <a className="login-button">
          <img
            src="../../assets/google-icon-png-transparent.png"
            alt=""
            className="login-button--img"
          />
        </a>
        <a className="login-button">
          <img src="./twitterIcon.png" alt="" className="login-button--img" />
        </a>
      </section>
      <section className="basic-login">
        <input type="rmail" placeholder="E-mail..." className="input-field" />
        <input
          type="password"
          placeholder="Password..."
          className="input-field"
        />
        <button
          onClick={props.signIn}
          className="purple-button side-margin--20 sign-up-button"
        >
          SIGN UP
        </button>
      </section>
    </div>
  );
};

export default SignIn;
