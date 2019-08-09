import React, { Component } from "react";
import EventInfo from "./eventInfo";
import Event from "../event";
import "../../styles/style_event.css";
import { getCityByEventId, getTenSimilarEvents } from "./apiRequests";

class ClickedEventView extends Component {
  state = {
    city: null,
    similarEvents: [],
    loadingSimilarEvents: true
  };

  componentDidMount() {
    getCityByEventId(this.props.event.id).then(city => {
      this.setState({ city, loadingEvent: false });
      getTenSimilarEvents(this.props.event).then(similarEvents => {
        this.setState({ similarEvents, loadingSimilarEvents: false });
      });
    });
  }

  render() {
    const { city, similarEvents, loadingSimilarEvents } = this.state;
    return (
      <div>
        <EventInfo event={this.props.event} city={city} />
        <section className="small-events">
          <h3>Similar events</h3>
          {similarEvents === undefined || loadingSimilarEvents ? (
            <div>Loading Similar Events...</div>
          ) : (
            similarEvents.map((similarEvent, index) => <Event key={1} />)
          )}
        </section>
      </div>
    );
  }
}

export default ClickedEventView;
