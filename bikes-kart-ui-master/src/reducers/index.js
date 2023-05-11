import { combineReducers } from "redux";
import bikes from "./bikes";
import login from "./login"
import message from "./message";
import feedbacks from "./feedbacks"


export default combineReducers({ bikes, login, message, feedbacks });
