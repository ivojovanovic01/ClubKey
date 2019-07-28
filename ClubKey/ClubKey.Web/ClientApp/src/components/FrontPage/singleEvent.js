import React from "react";

const SingleEvent = props => {
  return (
    <div onClick={props.click}>
      <p>{props.name}</p>
    </div>
  );
};

export default SingleEvent;
