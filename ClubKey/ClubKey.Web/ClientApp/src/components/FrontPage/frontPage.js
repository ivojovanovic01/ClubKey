import React, { Component } from "react";
import Event from "../SelectedEvent/selectedEvent";
import { GetTenEventsByLocation } from "./apiRequests";
import FrontPageHeader from "./frontPageHeader";
import SingleEvent from "./singleEvent";

class FrontPage extends Component {
  state = {
    whereToStartFrom: 0,
    numberOfPages: 1,
    events: []
  };

  componentDidMount() {
    GetTenEventsByLocation(response => {
      if (response < 10) {
        this.setState({ numberOfPages: 1 });
      }
      this.setState({ numberOfPages: response / 10 });
    });
  }

  handlePageChange() {}

  handleEventClick = event => <Event event={event} />;

  render() {
    const { events } = this.state;
    return (
      <div>
        <FrontPageHeader />
        {events.map((event, index) => (
          <SingleEvent
            click={this.handleEventClick}
            key={index}
            name={event.name}
          />
        ))}
      </div>
    );
  }
}

export default FrontPage;
