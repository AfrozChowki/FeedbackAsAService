import { RETRIEVE_FEEDBACKS } from "../actions/types";

const initialState = [];

export default function(feedbacks = initialState, action) {
  const { type, payload } = action;

  switch (type) {
    case RETRIEVE_FEEDBACKS:
      return payload;

    default:
      return feedbacks;
  }
}
