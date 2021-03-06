import React from "react";

const PaymentMethods = props => {
  return (
    <section className="payment-methods">
      <div className="section-title-wrapper">
        <span className="section-title">Payment Methods</span>
        <button className="button-less"></button>
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
