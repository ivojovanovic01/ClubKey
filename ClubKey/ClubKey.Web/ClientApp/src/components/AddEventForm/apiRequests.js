import axios from "axios";

export const AddEvent = (name, startTime, endTime) =>
  axios
    .get("api/events/add", { name, startTime, endTime })
    .then(() => {
      return true;
    })
    .catch(() => {
      alert("AddEvent failed");
    });
