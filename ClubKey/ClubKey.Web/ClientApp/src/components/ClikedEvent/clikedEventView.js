import React, { Component } from "react";
import EventInfo from "./eventInfo";
import Event from "../event";
import "../../styles/style_event.css";
import { getEventById, getTenSimilarEvents } from "./apiRequests";

class ClickedEventView extends Component {
  state = {
    similarEvents: [],
    event: null,
    loadings: {
      loadingEvent: true,
      loadingSimilarEvents: true
    }
  };

  componentDidMount() {
    getEventById(this.props.id).then(event => {
      this.setState({ event, loadingEvent: false });
      getTenSimilarEvents(event).then(similarEvents => {
        this.setState({ similarEvents, loadingSimilarEvents: false });
      });
    });
  }

  render() {
    const { similarEvents, loadings } = this.state;
    return (
      <div>
        {loadings.event ? <div>Loading Event...</div> : <EventInfo />}
        <section className="small-events">
          <h3>Similar events</h3>
          {similarEvents === undefined || loadings.similarEvents ? (
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
