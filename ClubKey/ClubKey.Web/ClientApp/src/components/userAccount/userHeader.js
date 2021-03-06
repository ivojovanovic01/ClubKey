import React from "react";
import "../../styles/style_profile.css";

const UserHeader = props => {
  return (
    <section className="account">
      <div className="account-image-wrapper">
        <img src="./teta.jpg" alt="" className="account-image" />
      </div>
      <div className="account-data">
        <h6>{props.user.firstName + " " + props.user.lastName}</h6>
        <button className="purple-button">EDIT</button>
      </div>
    </section>
  );
};

export default UserHeader;
