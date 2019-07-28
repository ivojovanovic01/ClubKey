import React, { Component } from "React";
import UserInformation from "./UserInformation";
import PaymentMethods from "./PaymentMethods";
import OrderReview from "./OrderReview";

class BuyingScreen extends Component {
  render() {
    return (
      <div>
        <UserInformation />
        <PaymentMethods />
        <OrderReview />
      </div>
    );
  }
}

export default BuyingScreen;
