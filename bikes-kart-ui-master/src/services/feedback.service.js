import http from "../feedback-http";

class FeedbackDataService {
    getAll() {
        return http.get('/api/Feedback');
    }
}

export default new FeedbackDataService();