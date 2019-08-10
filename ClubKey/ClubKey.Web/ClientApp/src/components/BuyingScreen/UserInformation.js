import React from "react";

const UserInformation = props => {
  return (
    <section className="user-information">
      <div className="section-title-wrapper">
        <span className="section-title">User information:</span>
        <button className="button-less">V</button>
      </div>
      <div className="section-container">
        <div className="purple-circle" />
        <div>
          <h4 className="user-basic-info">
            {props.user.firstName +
              " " +
              props.user.lastName}
          </h4>
          <p>
            <br />
            {props.user.email}
          </p>
        </div>
      </div>
    </section>
  );
};

export default UserInformation;
