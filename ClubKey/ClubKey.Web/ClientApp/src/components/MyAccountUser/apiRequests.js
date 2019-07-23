import axios from "axios";

export const GetUserByUsername = username =>
  axios
    .get("api/users/get-by-username", { params: { username } })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetUserByUsername failed");
    });

export const GetTicketsByUserId = userId =>
  axios
    .get("api/tickets/get-by-userId", { params: { userId } })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetTicketsByUserId failed");
    });

export const GetAchievementsByUserId = userId =>
  axios
    .get("api/achievements/get-by-userId", { params: { userId } })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetTenEvents failed");
    });
