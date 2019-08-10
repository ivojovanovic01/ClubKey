import axios from "axios";

export const getTenEventsByLocation = (cityId, pageNumber) =>
  axios
    .get("api/events/get-ten-by-city", {
      params: { cityId, pageNumber }
    })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetTenEventsByLocation failed");
    });

export const getNumberOfPagesByCityId = cityId =>
  axios
    .get("api/events/get-events-count-by-city", { params: { cityId } })
    .then(response => {
      return Math.ceil(response.data / 10);
    });

export const getClubByEventId = eventId =>
  axios
    .get("api/clubs/get-by-event", { params: { eventId } })
    .then(response => {
      return response.data;
    });
