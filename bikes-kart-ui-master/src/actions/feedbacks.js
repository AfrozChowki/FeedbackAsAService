import {
    RETRIEVE_FEEDBACKS
} from "./types";

import FeedbackDataService from "../services/feedback.service";

export const retrieveFeedbacks = () => async (dispatch) => {
    try {
        const res = await FeedbackDataService.getAll();

        dispatch({
            type: RETRIEVE_FEEDBACKS,
            payload: res.data
        });
    }
    catch(err){
        console.log(err);
    }
}