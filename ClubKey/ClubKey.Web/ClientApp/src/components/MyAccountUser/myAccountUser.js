import React, { Component } from "react";
import UserHeader from "./userHeader";
import Ticket from "./ticket";
import Achievement from "./achievement";

class MyAccountUser extends Component {
  state = {
    tickets = [],
    achievements = []
  }
  render() {
    return (
      <div>
        <UserHeader />
        <div>
          { tickets.map((ticket, index) => <Ticket key={index}/>)}
        </div>
        <div>
          { achievements.map((achievement, index) => <Achievement key={index}/>)}
        </div>
      </div>
    );
  }
}

export default MyAccountUser;
