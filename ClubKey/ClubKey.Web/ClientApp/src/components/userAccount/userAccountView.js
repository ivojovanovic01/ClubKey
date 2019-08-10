import React, { Component } from "react";
import UserHeader from "./userHeader";
import Ticket from "./ticket";
import Achievement from "./achievement";
import "../../styles/style_profile.css";
import NavMenu from "../NavMenu";
import {
  getAchievementsByUserId,
  getTicketsByUserId,
  getUserByUsername,
  getAllAchievements,
  getEventByTicketId
} from "./apiRequests";

class UserAccountView extends Component {
  state = {
    user: null,
    tickets: [],
    achievements: [],
    finishedAchievements: [],
      loadingUser: true,
      loadingAchievements: true,
      loadingTickets: true
  };

  componentDidMount() {
    this.getUser();
    this.getAchievements();
  }

  getUser = () => {
    getUserByUsername("iivanic12").then(user => {
      if (user !== undefined) {
        this.setState({ user, loadingUser: false });
        this.getFinishedAchievements(user);
        this.getTickets(user);
      }
    });
  };

  getFinishedAchievements = user => {
    getAchievementsByUserId(user.id).then(finishedAchievements => {
      this.setState({ finishedAchievements });
    });
  };

  getTickets = user => {
    getTicketsByUserId(user.id).then(tickets => {
      tickets.map((ticket, index) => {
        this.getEvent(ticket);
      });
    });
  };

  getEvent = ticket => {
    getEventByTicketId(ticket.id).then(event => {
      ticket.event = event;
	  let tickets = this.state.tickets;
	  tickets.push(ticket);
      this.setState({ tickets, loadingTickets: false });
    });
  };

  getAchievements = () => {
    getAllAchievements().then(achievements => {
      this.setState({ achievements, loadingAchievements: false });
    });
  };

  render() {
    const { tickets, achievements, user, loadingAchievements, 
			loadingTickets, loadingUser } = this.state;
    return (
      <div>
        {loadingUser || user === null ? (
          <div>Loading User Info...</div>
        ) : (
          <UserHeader user={user} />
        )}
        <section className="active-tickets">
          <h3 className="section-title">Active tickets</h3>
          {loadingTickets || tickets === undefined ? (
            <div>Loading Tickets...</div>
          ) : (
            tickets.map((ticket, index) => (
              <Ticket key={index} ticket={ticket}/>
            ))
          )}
        </section>
        <section className="achievements">
          <h3 className="section-title">Achievements</h3>
          {loadingAchievements || achievements === undefined ? (
            <div>Loading Achievements...</div>
          ) : (
            achievements.map((achievement, index) => (
              <Achievement key={index} achievement={achievement} />
            ))
          )}
        </section>
		<NavMenu />
      </div>
    );
  }
}

export default UserAccountView;
