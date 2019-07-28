import React, { Component } from "react";
import EventInfo from "./eventDetails";
import SingleEvent from "../FrontPage/singleEvent";

class Event extends Component {
  state = {
    similarEvents: []
  };
  render() {
    const { similarEvents } = this.state;
    return (
      <div>
        <EventInfo />
        {similarEvents.map((similarEvent, index) => (
          <SingleEvent key={index} />
        ))}
      </div>
    );
  }
}

export default Event;
