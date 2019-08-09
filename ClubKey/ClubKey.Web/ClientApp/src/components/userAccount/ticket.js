import React from "react";
import "../../styles/style_profile.css";

const Ticket = props => {
  console.log(props);
  return (
    <article className="ticket-wrapper">
      <div className="event">
        <h2>Monday party</h2>
        <div className="event--date">
          <span>{props.ticket.event.dateDay}</span>
          <span className="font-color--purple">{props.ticket.event.month}</span>
          <span>{props.ticket.event.time}</span>
        </div>
        <p>{props.ticket.event.name + ", " + props.ticket.event.location}</p>
        <p>Price: {props.ticket.price}</p>
      </div>
      <div className="buttons-wrapper">
        <button className="purple-button side-margin--20">SHOW QR</button>
        <button className="purple-button side-margin--20">REFUND</button>
      </div>
    </article>
  );
};

export default Ticket;
