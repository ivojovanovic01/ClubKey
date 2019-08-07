import axios from "axios";

export const getTenEventsByLocation = (cityId, whereToStartFrom) =>
  axios
    .get("api/events/get-ten-by-city", {
      params: { cityId, whereToStartFrom }
    })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetTenEventsByLocation failed");
    });

export const getNumberOfPages = cityId =>
  axios
    .get("api/events/get-by-cityId", { params: { cityId } })
    .then(response => {
      return Math.ceil(response.data.length / 10);
    });

export const getClubByEventId = eventId =>
  axios
    .get("api/clubs/get-by-eventId", { params: { eventId } })
    .then(response => {
      return response.data;
    });
