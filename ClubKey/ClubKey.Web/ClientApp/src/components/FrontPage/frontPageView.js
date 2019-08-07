import React, { Component } from "react";
import FrontPageHeader from "./frontPageHeader";
import Event from "../event";
import "../../styles/style_event.css";
import {
  getClubByEventId,
  getTenEventsByLocation,
  getNumberOfPages
} from "./apiRequests";

//Waitinh for getClubByEventId
class FrontPageView extends Component {
  state = {
    loadings: {
      loadingEvents: true,
      loadingHeader: true,
      loadingPageNumber: true
    },
    numberOfPages: 1,
    currentPage: 1,
    clubsAndEvents: [],
    cityId: 1
  };

  componentDidMount() {
    this.getCityId();
    this.getNumberOfPages();
    this.getEvents();
  }

  getCityId = () => {
    this.setState({ cityId: 1 });
  };

  getNumberOfPages = () => {
    this.setState({ numberOfPages: 3 });
  };

  getEvents = () => {
    getTenEventsByLocation(this.state.cityId, this.state.currentPage).then(
      events => {
        if (events !== undefined) {
          events.map((event, index) => {
            getClubByEventId(event.id).then((club, event) => {
              this.setState({
                ...this.state.clubsAndEvents,
                clubAndEvent: { event, club }
              });
            });
          });
          this.setState({ loadingEvents: false });
        }
      }
    );
  };

  changePage = event => {
    this.setState({ currentPage: event.target.value });
    this.getEvents();
  };

  handleEventClick = event => <Event event={event} />;

  render() {
    const { numberOfPages, clubsAndEvents, loadings } = this.state;
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
          {loadings.loadingEvents || clubsAndEvents !== undefined ? (
            <div>Loading Events...</div>
          ) : (
            clubsAndEvents.map((clubAndEvent, index) => (
              <Event
                click={this.handleEventClick}
                key={index}
                event={clubAndEvent.event}
                club={clubAndEvent.club}
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

export default FrontPageView;
