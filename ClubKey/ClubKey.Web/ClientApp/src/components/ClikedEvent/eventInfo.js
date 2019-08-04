import React from "react";
import "../../styles/style.css";
import "../../styles/style_event.css";

const EventInfo = props => {
  return (
    <div>
      <div className="event-header">
        <img src="./teta.jpg" alt="" className="club-img--big" />
        <h5 className="club-name--big">ZENTA</h5>
      </div>
      <div>
        <img src="./teta.jpg" alt="" className="heading-image" />
      </div>
      <section className="heading-event">
        <div className="heading_event-wrapper">
          <h1 className="heading_event--title">MONDAY PARTY</h1>
          <div className="music-by">
            Music by
            <h5 className="performer">DJ FLEX</h5>
          </div>
        </div>
        <p className="event--info">
          Ljetne vrućine već su se vratile u Split, a najbolji način za
          proslaviti vruće ljetne noći je svima poznati MONDAY TRASH u Zenta
          klubu!
        </p>
        <div className="event-date-price-wrapper">
          <h3 className="event--date">
            <span>22.</span>
            <span className="font-color--purple">JUL</span>
            <span>23h</span>
          </h3>
          <h3 className="event--price">Ticket price: 120kn</h3>
        </div>
        <button className="heading-event--button purple-button full-width">
          BUY NOW
        </button>
      </section>
    </div>
  );
};

export default EventInfo;
