import axios from "axios";

export const getEventById = id =>
  axios
    .get("api/events/get-by-id", { params: { id } })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetEventById failed");
    });

export const getTenSimilarEvents = (music, city) =>
  axios
    .get("api/events/get-ten-similar", { params: { music, city } })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetTenSimilarEvents failed");
    });

export const getCityByEventId = eventId =>
  axios
    .get("api/cities/get-by-event", { params: { eventId } })
    .then(response => {
      return response.data;
    });
