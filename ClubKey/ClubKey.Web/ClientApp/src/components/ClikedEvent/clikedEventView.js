import React, { Component } from "react";
import EventInfo from "./eventInfo";
import Event from "../event";
import "../../styles/style_event.css";
import NavMenu from "../NavMenu";
import { getClubByEventId, getTenSimilarEvents, getEventById } from "./apiRequests";

class ClickedEventView extends Component {
  state = {
    club: null,
	event: null,
    clubsAndSimilarEvents: [],
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
      		getTenSimilarEvents(this.state.event.id).then(similarEvents => {
				similarEvents.map((similarEvent, index) => {
					getClubByEventId(similarEvent.id).then(club => {
						var clubsAndSimilarEvents = this.state.clubsAndSimilarEvents;
						clubsAndSimilarEvents.push({ club, similarEvent});
						this.setState({ clubsAndSimilarEvents, loadingSimilarEvents: false });
			});
		});
      		});
    	});
  	});
  }

  render() {
    const { event, club, clubsAndSimilarEvents, loadingSimilarEvents, loadingEvent, loadingClub } = this.state;
	return (
      <div>
		{
			loadingEvent || loadingClub || event === undefined || club === undefined?
			<div>Loading Info ....</div> : 
        	<EventInfo event={event} club={club}/>
		}
        <section className="small-events">
          <h3>Similar events</h3>
          {clubsAndSimilarEvents === undefined || loadingSimilarEvents ? (
            <div>Loading Similar Events...</div>
          ) : (
            clubsAndSimilarEvents.map((clubAndSimilarEvent, index) => 
			<Event 
				event={clubAndSimilarEvent.similarEvent} 
				club={clubAndSimilarEvent.club}
				key={index} 
			/>
			)
          )}
        </section>
		<NavMenu />
      </div>
    );
  }
}

export default ClickedEventView;
