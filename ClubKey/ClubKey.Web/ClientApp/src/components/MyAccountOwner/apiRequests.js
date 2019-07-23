import axios from "axios";

export const GetOwnerByUsername = username =>
  axios
    .get("api/owners/get-by-username", { params: { username } })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetOwnerByUsername failed");
    });

export const GetClubsByOwnerId = ownerId =>
  axios
    .get("api/clubs/get-by-ownerId", { params: { ownerId } })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetClubsByOwnerId failed");
    });
