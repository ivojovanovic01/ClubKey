import React, { Component } from "react";
import UserInformation from "./userInformation";
import PaymentMethods from "./paymentMethods";
import OrderReview from "./orderReview";
import "../../styles/style_payment.css";

class BuyingScreenView extends Component {
  state = {
    event: null,
    city: null,
    numberOfTickets: 0,
    paymentMethods: []
  };
  render() {
    const { user, paymentMethods, event, city, numberOfTickets } = this.state;
    return (
      <div>
        <UserInformation user={user} />
        <PaymentMethods paymentMethods={paymentMethods} />
        <OrderReview
          event={event}
          city={city}
          numberOfTickets={numberOfTickets}
        />
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
