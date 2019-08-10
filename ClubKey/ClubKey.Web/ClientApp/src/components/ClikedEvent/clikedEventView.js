import React, { Component } from "react";
import EventInfo from "./eventInfo";
import Event from "../event";
import "../../styles/style_event.css";
import { getClubByEventId, getTenSimilarEvents, getEventById } from "./apiRequests";

class ClickedEventView extends Component {
  state = {
    club: null,
	event: null,
    similarEvents: [],
    loadingSimilarEvents: true,
	loadingEvent: true,
	loadingClub: true
  };

  componentDidMount() {
	const { id } = this.props.match.params;
	getEventById(id).then(event => {
		this.setState({ event, loadingEvent: false });
    	getClubByEventId(id).then(club => {
      		this.setState({ club, loadingClub: false });
      		getTenSimilarEvents(this.state.event).then(similarEvents => {
        		this.setState({ similarEvents, loadingSimilarEvents: false });
      		});
    	});
  	});
  }

  render() {
    const { event, club, similarEvents, loadingSimilarEvents, loadingEvent, loadingClub } = this.state;
    return (
      <div>
		{
			loadingEvent || loadingClub || event === undefined || club === undefined?
			<div>Loading Info ....</div> : 
        	<EventInfo event={event} club={club}/>
		}
        <section className="small-events">
          <h3>Similar events</h3>
          {similarEvents === undefined || loadingSimilarEvents ? (
            <div>Loading Similar Events...</div>
          ) : (
            similarEvents.map((similarEvent, index) => 
			<Event event={similarEvent} key={index} />
			)
          )}
        </section>
      </div>
    );
  }
}

export default ClickedEventView;
