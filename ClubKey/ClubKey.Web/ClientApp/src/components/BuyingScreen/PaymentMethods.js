import React from "./node_modules/react";

const PaymentMethods = props => {
  return (
    <section className="payment-methods">
      <div className="section-title-wrapper">
        <span className="section-title">Payment Methods</span>
        <button className="button-less">V</button>
      </div>
      <div className="section-container">
        <div className="purple-circle" />
        <img
          src="./1-Visalogo-forplacementfirst..png"
          alt=""
          className="credit-card-logo"
        />
        <p />
      </div>
    </section>
  );
};

export default PaymentMethods;
