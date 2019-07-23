import axios from "axios";

export const GetEventsByClubId = clubId =>
  axios
    .get("api/events/get-by-clubId", { params: { clubId } })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetEventsByClubId failed");
    });
