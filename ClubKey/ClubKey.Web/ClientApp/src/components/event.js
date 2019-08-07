import React from "react";
import "../styles/style.css";
import "../styles/style_event.css";

const Event = props => {
  return (
    <article className="small-event">
      <div className="event-header">
        <img src="./teta.jpg" alt="" className="club-img" />
        <h5 className="club-name">{this.props.event.name}</h5>
      </div>
      <img src="./teta.jpg" alt="" className="small-event--img" />
      <div className="small-event--info">
        <h2 className="small-event-info--date">
          <span>22</span>
          <span className="font-color--purple">JUL</span>
          <span>23h</span>
        </h2>
        <div>
          <h4 className="small-event-info--title">Šampanjac party</h4>
          <p className="small-event-info--tags">
            #party #narodnjaci #freedrinks #maturalna #reggeto
          </p>
        </div>
        <div className="small-event-btn">
          <button className="purple-button side-margin--20">BUY</button>
        </div>
      </div>
    </article>
  );
};

export default Event;
