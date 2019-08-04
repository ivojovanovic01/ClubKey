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
    .get("api/tickets/get-by-userId", { params: { userId } })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetTicketsByUserId failed");
    });

export const getAchievementsByUserId = userId =>
  axios
    .get("api/achievements/get-by-userId", { params: { userId } })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetTenEvents failed");
    });

export const GetAllAchievements = () =>
  axios.get("api/achievements/all").then(response => {
    return response.data;
  });
