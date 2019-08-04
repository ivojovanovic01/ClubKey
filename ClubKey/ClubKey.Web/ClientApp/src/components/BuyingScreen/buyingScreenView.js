import React, { Component } from "react";
import UserInformation from "./userInformation";
import PaymentMethods from "./paymentMethods";
import OrderReview from "./orderReview";
import "../../styles/style_payment.css";

class BuyingScreenView extends Component {
  render() {
    return (
      <div>
        <UserInformation />
        <PaymentMethods />
        <OrderReview />
        <section className="discount-code">
          <h6 className="discount-code-title">Discount code:</h6>
          <input type="text" placeholder="Code..." className="input-field" />
        </section>
        <button className="purple-button full-width">BUY NOW</button>
      </div>
    );
  }
}

export default BuyingScreenView;
