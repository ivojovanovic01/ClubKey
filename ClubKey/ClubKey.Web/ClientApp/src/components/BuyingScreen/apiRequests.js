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

export const getCityByEventId = eventId =>
  axios
    .get("api/cities/get-by-event", { params: { eventId } })
    .then(response => {
      return response.data;
    });

export const getEventById = id =>
  axios
    .get("api/events/get-by-id", { params: { id } })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetEventById failed");
    });

export const GetUserById = id =>
  axios
    .get("api/user/get-by-id", { params: { id } })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetUserById failed");
    });