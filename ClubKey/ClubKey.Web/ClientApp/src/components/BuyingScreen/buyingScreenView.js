import React, { Component } from "react";
import UserInformation from "./userInformation";
import PaymentMethods from "./paymentMethods";
import OrderReview from "./orderReview";
import "../../styles/style_payment.css";
import {
  addTicket,
  addPaymentMethod,
  getCityByEventId,
  getPaymentMethodsByUserId
} from "./apiRequests";

class BuyingScreenView extends Component {
  state = {
    city: null,
    numberOfTickets: 0,
    paymentMethods: [],
    loadings: { loadingOrder: true, loadingPaymentMethods: true }
  };

  componentDidMount() {
    this.getCity();
    this.getPaymentMethods();
  }

  getCity = () => {
    getCityByEventId(this.props.event).then(city => {
      this.setState({ city });
      this.setState({ ...loadings, loadingOrder: false });
    });
  };

  getPaymentMethods = () => {
    getPaymentMethodsByUserId(this.props.user).then(paymentMethods => {
      this.setState({ paymentMethods });
      this.setState({ ...loadings, loadingPaymentMethods: false });
    });
  };

  render() {
    const { loadings, paymentMethods, city, numberOfTickets } = this.state;
    return (
      <div>
        <UserInformation user={this.props.user} />
        {loadings.loadingPaymentMethods || paymentMethods === undefined ? (
          <div>Loading Payment</div>
        ) : (
          <PaymentMethods paymentMethods={paymentMethods} />
        )}
        <OrderReview
          event={this.props.event}
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
