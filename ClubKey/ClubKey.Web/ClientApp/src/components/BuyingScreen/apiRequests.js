import axios from "axios";

export const addTicket = (userId, eventId, price) =>
  axios
    .post("api/tickets/add", { params: { userId, eventId, price } })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("AddTicket failed");
    });

export const addPaymentMethod = () => {
  axios
    .post("api/payment-methods/add", { params: {} })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("AddPaymentMethodFailed");
    });
};
export const getPaymentMethodsByUserId = userId =>
  axios
    .get("api/payment-methods/get-by-user", { params: { userId } })
    .then(response => {
      return response.data;
    });

export const getCityByClubId = clubId =>
  axios
    .get("api/cities/get-by-club", { params: { clubId } })
    .then(response => {
      return response.data;
    });

export const getClubByEventId = eventId =>
  axios
    .get("api/clubs/get-by-event", { params: { eventId } })
    .then(response => {
      return response.data;
    });

export const getEvent = eventId =>
  axios
    .get("api/events/get-by-id", { params: { eventId } })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetEventById failed");
    });

export const getUserById = username =>
  axios
    .get("api/users/get-by-username", { params: { username } })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetUserById failed");
    });