import axios from "axios";

export const getUserByUsername = username =>
  axios
    .get("api/users/get-by-username", { params: { username } })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetUserByUsername failed");
    });

export const getTicketsByUserId = userId =>
  axios
    .get("api/tickets/get-by-user", { params: { userId } })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetTicketsByUserId failed");
    });

export const getAchievementsByUserId = userId =>
  axios
    .get("api/achievements/get-by-id", { params: { userId } })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetAchievements failed");
    });

export const getAllAchievements = () =>
  axios.get("api/achievements/all").then(response => {
    return response.data;
  });

export const getEventByTicketId = ticketId =>
  axios
    .get("api/events/get-event-by-ticketId", { params: { ticketId } })
    .then(response => {
      return response.data;
    });
