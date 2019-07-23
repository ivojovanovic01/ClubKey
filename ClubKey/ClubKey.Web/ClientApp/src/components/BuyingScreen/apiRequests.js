import axios from "axios";

export const AddTicket = (userId, eventId) =>
  axios
    .get("api/tickets/add", { params: { userId, eventId } })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("AddTicket failed");
    });
