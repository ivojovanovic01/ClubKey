import axios from "axios";

export const getEventById = eventId =>
  axios
    .get("api/events/get-by-id", { params: { eventId } })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetEventById failed");
    });

export const getTenSimilarEvents = eventId =>
  axios
    .get("api/events/get-ten-similar-events", { params: { eventId } })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetTenSimilarEvents failed");
    });

export const getClubByEventId = eventId =>
  axios
    .get("api/clubs/get-by-event", { params: { eventId } })
    .then(response => {
      return response.data;
    });
