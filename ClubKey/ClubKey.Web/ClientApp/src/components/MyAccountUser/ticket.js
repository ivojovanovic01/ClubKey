import React from "react";
import "../../styles/style_profile";

const Ticket = props => {
  return (
    <article className="ticket-wrapper">
      <div className="event">
        <h2>Monday party</h2>
        <div className="event--date">
          <span>22.</span>
          <span className="font-color--purple">JUL</span>
          <span>23h</span>
        </div>
        <p>Zenta, Split</p>
        <p>Price: 120kn</p>
      </div>
      <div className="buttons-wrapper">
        <button className="purple-button side-margin--20">SHOW QR</button>
        <button className="purple-button side-margin--20">REFUND</button>
      </div>
    </article>
  );
};

export default Ticket;
