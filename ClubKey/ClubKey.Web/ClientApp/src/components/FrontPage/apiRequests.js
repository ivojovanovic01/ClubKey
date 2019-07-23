import axios from "axios";

export const GetTenEventsByLocation = whereToStartFrom =>
  axios
    .get("api/events/get-ten-by-location", { params: { whereToStartFrom } })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetTenEventsByLocation failed");
    });
