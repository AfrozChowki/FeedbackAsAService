import React, { Component } from "react";
import { connect } from "react-redux";
import { Redirect } from "react-router-dom";
import { retrieveFeedbacks } from "../actions/feedbacks"
import Table from 'react-bootstrap/Table';
import {feedbackCategories} from '../helpers/categories'
import Pie from "./pie-graph.component";

class FeedbackDashboard extends Component {
    constructor(props){
        super(props);
    }

    componentDidMount(){
        this.props.retrieveFeedbacks();
    }

    componentDidUpdate(prevProps, prevState){
        if(this.props.feedbacks.length > 0){
            pieGraphData(this.props.feedbacks);
        }
    }

    render () {
        const { feedbacks, loginInfo } = this.props;
        if(!loginInfo.isLoggedIn){
          return <Redirect to="/"/>
        }

        return (
            <>
        <div className="list row">
        <div className="col-md-6">
          <h4>Feedbacks</h4>

          <Table striped bordered hover>
      <thead>
        <tr>
          <th>#</th>
          <th>Application</th>
          <th>User Id</th>
          <th>Page URL</th>
          <th>Page Name</th>
          <th>Feedback</th>
          <th>Page Rating</th>
          <th>Category</th>
          <th>Images</th>
          <th>Received Date</th>
        </tr>
      </thead>
      <tbody>
      {feedbacks &&
              feedbacks.map((feedback, index) => (
                <tr>
                <td>{index + 1}</td>
                <td>{feedback.projectName}</td>
                <td>{feedback.userId}</td>
                <td>{feedback.pageUrl}</td>
                <td>{feedback.pageName}</td>
                <td>{feedback.feedbackMessage}</td>
                <td>{feedback.rating}</td>
                <td>{feedbackCategories[feedback.categoryId]}</td>
                <td><a src={feedback.image}>image</a></td>
                <td>{feedback.createdOn}</td>
              </tr>
              ))}
      </tbody>
    </Table>
          </div>
        </div>
        
        <div className="list row">
        <div className="col-md-6">
          <h4>Category wise analysis</h4>
           {feedbacks &&
            <Pie
            data={pieGraphData(feedbacks)}
            width={200}
            height={200}
            innerRadius={60}
            outerRadius={100}
          />
           }
           </div>
        </div>
        </>
        );
    }
}

const pieGraphData = (feedbacks) => {
 var map = new Array();

 for(let i=1; i<feedbackCategories.length; i++){
    var categoryCount = feedbacks.filter(function(el) {
        return el.categoryId == i;
    }).length;
    map.push({name: feedbackCategories[i], value: categoryCount})
 }
return map;
}

const mapStateToProps = (state) => {
    return {
        feedbacks: state.feedbacks,
        loginInfo: state.login
    };
};

export default connect(mapStateToProps, {
     retrieveFeedbacks
})(FeedbackDashboard);