import axios from "./node_modules/axios";

export const addTicket = (userId, eventId) =>
  axios
    .post("api/tickets/add", { params: { userId, eventId } })
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
