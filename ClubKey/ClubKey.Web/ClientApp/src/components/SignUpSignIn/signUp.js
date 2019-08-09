import React from "react";
import { Link } from "react-router";

const SignUp = props => {
  return (
    <div>
      <section className="social-networks-login">
        <a className="login-button">
          <img
            src="../../assets/fbIcon.png"
            alt=""
            className="login-button--img"
          />
        </a>
        <a className="login-button">
          <img
            src="../../assets/google-icon-logo-png-transparent.png"
            alt=""
            className="login-button--img"
          />
        </a>
        <a className="login-button">
          <img
            src="../../assets/twitterIcon.png"
            alt=""
            className="login-button--img"
          />
        </a>
      </section>
      <section className="sign-up">
        <input
          type="text"
          placeholder="First name..."
          className="input-field"
        />
        <input type="text" placeholder="Last name..." className="input-field" />
        <input type="email" placeholder="E-mail..." className="input-field" />
        <input
          type="date"
          placeholder="Date of birth..."
          className="input-field"
        />
        <input
          type="password"
          placeholder="Password..."
          className="input-field"
        />
        <input
          type="password"
          placeholder="Password again..."
          className="input-field"
        />
        <input type="file" name="pic" accept="image/*" className="file-input" />
        <button
          onClick={props.signUp}
          className="purple-button side-margin--20"
        >
          SIGN UP
        </button>
      </section>
      <section className="log-in">
        <p className="log-in--text">Already have an account?</p>
        <button
          onClick={props.changeToSignInPage}
          className="purple-button side-margin--20"
        >
          LOG IN
        </button>
      </section>
    </div>
  );
};

export default SignUp;
