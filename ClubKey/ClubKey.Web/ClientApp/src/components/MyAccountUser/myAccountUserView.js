import React, { Component } from "react";
import UserHeader from "./userHeader";
import Ticket from "./ticket";
import Achievement from "./achievement";
import "../../styles/style_profile";

class MyAccountUserView extends Component {
  state = {
    tickets: [],
    achievements: []
  };
  render() {
    const { tickets, achievements } = this.state;
    return (
      <div>
        <UserHeader />
        <section className="active-tickets">
          <h3 className="section-title">Active tickets</h3>
          {tickets.map((ticket, index) => (
            <Ticket key={index} />
          ))}
        </section>
        <section className="achievements">
          <h3 className="section-title">Achievements</h3>
          {achievements.map((achievement, index) => (
            <Achievement key={index} />
          ))}
        </section>
      </div>
    );
  }
}

export default MyAccountUserView;
