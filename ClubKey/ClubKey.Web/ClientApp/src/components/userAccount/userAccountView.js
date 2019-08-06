import React, { Component } from "react";
import UserHeader from "./userHeader";
import Ticket from "./ticket";
import Achievement from "./achievement";
import "../../styles/style_profile.css";
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
    loadings: {
      loadingUser: true,
      loadingAchievements: true,
      loadingTickets: true
    }
  };

  componentDidMount() {
    this.getUser();
    this.getAchievements();
  }

  //Hardcoded username for testing
  getUser = () => {
    getUserByUsername("iivanic12").then(user => {
      if (user !== undefined) {
        let loadings = { ...this.state.loadings };
        loadings.loadingUser = false;
        this.setState({ user, loadings });
        this.getFinishedAchievements(user);
        this.getTickets(user);
      }
    });
  };

  getFinishedAchievements = () => {
    getAchievementsByUserId(user.id).then(finishedAchievements => {
      this.setState({ finishedAchievements });
    });
  };

  getTickets = () => {
    getTicketsByUserId(user.id).then(tickets => {
      tickets.map((ticket, index) => {
        this.getEvent(ticket);
      });
      let loadings = { ...this.state.loadings };
      loadings.loadingTickets = false;
      this.setState({ loadings });
    });
  };

  getEvent = ticket => {
    getEventByTicketId(ticket.id).then(event => {
      ticket.event = event;
      this.setState({ ...tickets, ticket });
    });
  };

  getAchievements = () => {
    getAllAchievements().then(achievements => {
      let loadings = { ...this.state.loadings };
      loadings.loadingAchievements = false;
      this.setState({ achievements, loadings });
    });
  };

  render() {
    const { tickets, achievements, user, loadings } = this.state;
    return (
      <div>
        {loadings.loadingUser || user === null ? (
          <div>Loading User Info...</div>
        ) : (
          <UserHeader user={user} />
        )}
        <section className="active-tickets">
          <h3 className="section-title">Active tickets</h3>
          {loadings.loadingTickets || tickets == undefined ? (
            <div>Loading Tickets...</div>
          ) : (
            tickets.map((ticket, index) => (
              <Ticket key={index} ticket={ticket} />
            ))
          )}
        </section>
        <section className="achievements">
          <h3 className="section-title">Achievements</h3>
          {loadings.loadingAchievements || achievements === undefined ? (
            <div>Loading Achievements...</div>
          ) : (
            achievements.map((achievement, index) => (
              <Achievement key={index} achievement={achievement} />
            ))
          )}
        </section>
      </div>
    );
  }
}

export default UserAccountView;
