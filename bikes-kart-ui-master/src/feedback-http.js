import axios from "axios";

export default axios.create({
  baseURL: "https://localhost:7271",
  headers: {
    "Content-type": "application/json",
    'Access-Control-Allow-Origin': '*',
    'Access-Control-Allow-Credentials': 'true'
  }
});