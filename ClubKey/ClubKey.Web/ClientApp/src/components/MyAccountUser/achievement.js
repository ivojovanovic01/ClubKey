import React from "react";
import "../../styles/style_profile.css";

const Achievement = props => {
  return (
    <div className="achievement-wrapper">
      <div>
        <img src="./teta.jpg" alt="" className="achievement-image" />
      </div>
      <p>{props.achievement.name}</p>
    </div>
  );
};

export default Achievement;
