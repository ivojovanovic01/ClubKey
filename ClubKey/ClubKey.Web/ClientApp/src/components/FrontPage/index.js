import React, { Component } from "react";
import { Link } from "react-router";
import { GetTenEventsByLocation } from "./apiRequests";

class Index extends Component {
  state = {
    whereToStartFrom: 0,
    numberOfPages: 1
  };

  componentDidMount() {
    GetTenEventsByLocation(response => {
      if (response < 10) {
        this.setState({ numberOfPages: 1 });
      }
      this.setState({ numberOfPages: response / 10 });
    });
  }
  handlePageChange() {}

  render() {
    return <div>Index</div>;
  }
}

export default Index;
