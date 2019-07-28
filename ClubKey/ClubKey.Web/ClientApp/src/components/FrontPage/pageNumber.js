import React from "react";

const PageNumber = props => {
  return <span onClick={props.click}>{props.key}</span>;
};

export default PageNumber;
