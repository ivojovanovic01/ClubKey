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
          <h4 className="ticket-basic-info">Ticket for {props.event.name}</h4>
          <div className="ticket-info-container">
            <div className="club-location">
              <p>
                Seller{" "}
                {props.club.name +
                  " " +
                  props.club.address +
                  ", " +
                  props.club.city +
                  ", " +
                  props.club.city.country +
                  ", " +
                  props.club.city.postalNumber}
              </p>
            </div>
            <div className="ticket-amount">
              <div className="number-of-tickets">
                <button className="plus-minus-button">-</button>
                <h4>{props.numberOfTickets}</h4>
                <button className="plus-minus-button">+</button>
              </div>
              <div className="total-price">
                <h5>Total</h5>
                <h4>{props.event.price * props.numberOfTickets}</h4>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
  );
};

export default OrderReview;
