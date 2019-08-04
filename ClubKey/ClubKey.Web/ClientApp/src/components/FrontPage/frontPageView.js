import React, { Component } from "react";
import FrontPageHeader from "./frontPageHeader";
import Event from "../event";
import "../../styles/style_event.css";
import { getTenEventsByLocation, getNumberOfPages } from "./apiRequests";

class FrontPage extends Component {
  state = {
    loadings: {
      loadingEvents: true,
      loadingHeader: true,
      loadingPageNumber: true
    },
    numberOfPages: 0,
    currentPage: 0,
    events: [],
    cityId: 1
  };

  componentDidMount() {
    let numberOfPages = getNumberOfPages();
    this.setState({ numberOfPages });
    this.getEvents();
  }

  getEvents = () => {
    getTenEventsByLocation(this.state.cityId, this.state.currentPage).then(
      response => {
        this.setState({ events: response, loadingEvents: false });
      }
    );
  };

  changePage = event => {
    this.setState({ PageNumber: event.target.value });
    this.getEvents();
  };

  handleEventClick = event => <Event event={event} />;

  render() {
    const { numberOfPages, events, loadings } = this.state;
    let numberArray = [];
    for (let i = 1; i < numberOfPages + 1; i++) {
      numberArray.push(i);
    }
    return (
      <div>
        {loadings.loadingHeader === true ? (
          <div>Loading...</div>
        ) : (
          <FrontPageHeader />
        )}
        <section className="small-events">
          <h3>Events</h3>
          {loadings.loadingEvents || events !== undefined ? (
            <div>Loading Events...</div>
          ) : (
            events.map((event, index) => (
              <Event
                click={this.handleEventClick}
                key={index}
                name={event.name}
              />
            ))
          )}
        </section>
        {loadings.loadingPageNumber ? (
          <div>Loading page number...</div>
        ) : (
          <div>
            {numberArray.map(pageNumber => (
              <span key={pageNumber} onClick={this.getEvents}>
                {pageNumber}
              </span>
            ))}
          </div>
        )}
      </div>
    );
  }
}

export default FrontPage;
