import React, { Component } from "react";
import FrontPageHeader from "./frontPageHeader";
import Event from "../event";
import NavMenu from "../NavMenu";
import "../../styles/style_event.css";
import "../../styles/style_home.css";
import {
  getClubByEventId,
  getTenEventsByLocation,
  getNumberOfPagesByCityId
} from "./apiRequests";

class FrontPageView extends Component {
  state = {
    loadingEvents: true,
    loadingPageNumber: true,
    numberOfPages: 1,
    currentPage: 1,
    clubsAndEvents: [],
    cityId: 1
  };

  componentDidMount() {
	localStorage.setItem("name", "iivanic12");
    this.getCityId();
    this.getNumberOfPages();
  }

  getCityId = () => {
    this.setState({ cityId: 1 });
  };

  getNumberOfPages = () => {
    getNumberOfPagesByCityId(this.state.cityId).then(numberOfPages => {
      this.setState({ numberOfPages, loadingPageNumber: false });
      this.getEvents(this.state.cityId);
    });
  };

  getEvents = () => {
    getTenEventsByLocation(this.state.cityId, this.state.currentPage).then(
      events => {
		events.map((event, index) => {
			getClubByEventId(event.id).then(club => {
				var clubsAndEvents = this.state.clubsAndEvents;
				clubsAndEvents.push({ club, event});
				this.setState({ clubsAndEvents });
			});
		});
		this.setState({ loadingEvents: false });
      }
    );
  };

  hanldeChangePage = event => {
    this.setState({ currentPage: event.target.value });
    this.getEvents();
  };

  handleEventClick = event => <Event event={event} />;

  render() {
    const { numberOfPages, clubsAndEvents, loadingEvents, loadingPageNumber } = this.state;
    let numberArray = [];
    for (let i = 1; i < numberOfPages + 1; i++) {
      numberArray.push(i);
    }
    return (
      <div>
        <FrontPageHeader />
        <section className="small-events">
          <h3>Events</h3>
          {loadingEvents || clubsAndEvents === undefined ? (
            <div>Loading Events...</div>
          ) : (
            clubsAndEvents.map((clubAndEvent, index) => (
              <Event
                eventClick={this.handleEventClick}
                key={index}
                event={clubAndEvent.event}
                club={clubAndEvent.club}
              />
            ))
          )}
        </section>
        {loadingPageNumber ? (
          <div>Loading page number...</div>
        ) : (
          <div>
            {numberArray.map(pageNumber => (
              <span key={pageNumber} onClick={this.hanldeChangePage}>
                {pageNumber}
              </span>
            ))}
          </div>
        )}
		<NavMenu />
      </div>
    );
  }
}

export default FrontPageView;
