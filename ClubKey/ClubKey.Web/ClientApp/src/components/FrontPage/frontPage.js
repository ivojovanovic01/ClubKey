import React, { Component } from "react";
import Event from "../SelectedEvent/selectedEvent";
import FrontPageHeader from "./frontPageHeader";
import SingleEvent from "./singleEvent";
import { GetTenEventsByLocation, getNumberOfPages } from "./apiRequests";

class FrontPage extends Component {
  state = {
    numberOfPages: 0,
    currentPage: 0,
    events: []
  };

  componentDidMount() {
    let numberOfPages = getNumberOfPages();
    this.setState({ numberOfPages });
    getEvents();
  }

  getEvents = event => {
    let currentPage = event.target.value;
    GetTenEventsByLocation(cityId, currentPage).then(response => {
      this.setState({ events: response, currentPage });
    });
  };

  handleEventClick = event => <Event event={event} />;

  render() {
    const { numberOfPages, events } = this.state;
    let numberArray = [];
    for (let i = 1; i < numberOfPages + 1; i++) {
      numberArray.push(i);
    }
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
        <div>
          {numberArray.map(pageNumber => (
            <PageNumber key={pageNumber} click={this.getEvents} />
          ))}
        </div>
      </div>
    );
  }
}

export default FrontPage;
