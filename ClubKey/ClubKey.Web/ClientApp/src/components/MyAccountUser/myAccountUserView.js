import React, { Component } from "react";
import UserHeader from "./userHeader";
import Ticket from "./ticket";
import Achievement from "./achievement";
import "../../styles/style_profile.css";
import {
  getAchievementsByUserId,
  getTicketsByUserId,
  getUserByUsername,
  GetAllAchievements
} from "./apiRequests";

class MyAccountUserView extends Component {
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
    getUserByUsername(localStorage.getItem("iivanic12")).then(user => {
      console.log(user);
      if (user !== undefined) {
        this.setState({ user, loadingUser: false });
        getAchievementsByUserId(user.Id).then(finishedAchievements => {
          this.setState({ finishedAchievements });
        });
        getTicketsByUserId(user.Id).then(tickets => {
          this.setState({ tickets, loadingTickets: false });
        });
      }
    });
  };

  getAchievements = () => {
    GetAllAchievements().then(achievements => {
      this.setState({ achievements, loadingAchievements: false });
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
          {loadings.loadingTickets || tickets === undefined ? (
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

export default MyAccountUserView;
