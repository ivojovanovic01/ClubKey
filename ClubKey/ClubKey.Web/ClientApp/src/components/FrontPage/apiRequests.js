import axios from "axios";

export const getTenEventsByLocation = (cityId, whereToStartFrom) =>
  axios
    .get("api/events/get-ten-by-city", {
      params: { cityId: 1, whereToStartFrom }
    })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetTenEventsByLocation failed");
    });

export const getNumberOfPages = cityId =>
  axios
    .get("api/cities/get-number-of-events", { params: { cityId: 1 } })
    .then(response => {
      return Math.ceil(response.date / 10);
    });
