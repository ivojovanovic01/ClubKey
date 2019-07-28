import axios from "axios";

export const GetUserById = id =>
  axios
    .get("api/user/get-by-id", { params: { id } })
    .then(response => {
      return response.data;
    })
    .catch(() => {
      alert("GetUserById failed");
    });

export const AddUser = (
  username,
  password,
  firstName,
  lastName,
  dateOfBirth,
  image
) =>
  axios
    .get("api/user/add", {
      username,
      password,
      firstName,
      lastName,
      dateOfBirth,
      image
    })
    .then(() => {
      return true;
    })
    .catch(() => {
      alert("AddEvent failed");
    });
