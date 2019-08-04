import React from "react";

const OrderReview = props => {
  return (
    <section className="order-review">
      <div className="section-title-wrapper">
        <span className="section-title">Order review</span>
        <button className="button-less">V</button>
      </div>
      <div className="section-container">
        <div className="purple-circle" />
        <div className="ticket-wrapper">
          <h4 className="ticket-basic-info">Ticket for Vodka party</h4>
          <div className="ticket-info-container">
            <div className="club-location">
              <p>Seller Quazi Put Bačvica, Split, Croatia, 21000</p>
            </div>
            <div className="ticket-amount">
              <div className="number-of-tickets">
                <button className="plus-minus-button">-</button>
                <h4>1</h4>
                <button className="plus-minus-button">+</button>
              </div>
              <div className="total-price">
                <h5>Total</h5>
                <h4>30 kn</h4>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
  );
};

export default OrderReview;
