import React from "react";
import { Link } from "react-router-dom";
import "../../styles/style.css";
import "../../styles/style_event.css";

const EventInfo = props => {
	const musicians = props.event.musicians;
  return (
    <div>
      <div className="event-header">
        <img src="./teta.jpg" alt="" className="club-img--big" />
        <h5 className="club-name--big">{props.club.name}</h5>
      </div>
      <div>
        <img src="./teta.jpg" alt="" className="heading-image" />
      </div>
      <section className="heading-event">
        <div className="heading_event-wrapper">
          <h1 className="heading_event--title">{props.event.name}</h1>
          <div className="music-by">
            Music by 
            <h5 className="performer">{}</h5>
          </div>
        </div>
        <p className="event--info">
          {props.event.description}
        </p>
        <div className="event-date-price-wrapper">
          <h3 className="event--date">
            <span>22.</span>
            <span className="font-color--purple">JUL</span>
            <span>23h</span>
          </h3>
          <h3 className="event--price">Ticket price: {props.event.price}</h3>
        </div>
		<Link to={`/buy-ticket/` + props.event.id}>
			<button className="heading-event--button purple-button full-width">
			BUY NOW
			</button>
		</Link>
      </section>
    </div>
  );
};

export default EventInfo;
