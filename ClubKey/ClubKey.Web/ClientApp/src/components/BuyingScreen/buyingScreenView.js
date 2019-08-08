import React, { Component } from "react";
import UserInformation from "./userInformation";
import PaymentMethods from "./paymentMethods";
import OrderReview from "./orderReview";
import "../../styles/style_payment.css";
import { Redirect } from "react-router-dom";
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

  renderRedirect = () => {
    console.log("here");
    console.log(this.props.user);
    if (this.props.user === undefined) {
      <Redirect to="/index" />;
    }
  };

  componentDidMount() {
    if (this.props.user) this.getCity();
    this.getPaymentMethods();
  }

  getCity = () => {
    getCityByEventId(this.props.event).then(city => {
      this.setState({ city });
      this.setState({ ...this.state.loadings, loadingOrder: false });
    });
  };

  getPaymentMethods = () => {
    getPaymentMethodsByUserId(this.props.user).then(paymentMethods => {
      this.setState({ paymentMethods });
      this.setState({ ...this.state.loadings, loadingPaymentMethods: false });
    });
  };

  render() {
    const { loadings, paymentMethods, city, numberOfTickets } = this.state;
    return (
      <div>
        {this.renderRedirect()}
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
