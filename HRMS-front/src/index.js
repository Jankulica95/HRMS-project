import React from "react";
import ReactDOM from "react-dom";
import "./index.css";
import App from "./App";
import { BrowserRouter as Router, Route, Switch } from "react-router-dom";
import AddCandidate from "./AddCandidate";
import Navbar from "./Navbar";
import CreateSkill from "./CreateSkill";

ReactDOM.render(
  <React.StrictMode>
    <Router>
      <Navbar />
      <Switch>
        <Route exact path="/">
          <App />
        </Route>
        <Route path="/addCandidate">
          <AddCandidate />
        </Route>
        <Route path="/createSkill">
          <CreateSkill />
        </Route>
      </Switch>
    </Router>
  </React.StrictMode>,
  document.getElementById("root")
);
