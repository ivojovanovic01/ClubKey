import axios from "axios";

export const GetEventById = id =>
  axios
    .get("api/events/get-by-id", { params: { id } })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetEventById failed");
    });

export const GetTenSimilarEvents = (music, city) =>
  axios
    .get("api/events/get-ten-similar", { params: { music, city } })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetTenSimilarEvents failed");
    });
