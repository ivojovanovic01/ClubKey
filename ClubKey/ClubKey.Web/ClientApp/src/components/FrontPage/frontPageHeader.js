import React from "react";

const FrontPageHeader = () => {
  return (
    <div className="header_info">
      <div>
        <h1>Best tickets online</h1>
      </div>
      <div>
        <h2>
          <a className="textColor__purple">Register </a>
          for awesome bonuses and achivements
        </h2>
      </div>
      <div className="header_button">
        <button className="purple-button side-margin--20">SIGN UP</button>
      </div>
    </div>
  );
};

export default FrontPageHeader;
