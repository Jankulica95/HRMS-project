import React from "react";
import logo from "./logoIntens.png";
import { Link } from "react-router-dom";

const Navbar = () => {
  return (
    <nav>
      <div className="nav-center">
        <div className="nav-header">
          <img className="logo" src={logo} alt="logo" />
        </div>
        <div className="links-container">
          <ul className="links">
            <li>
              <a href="/">All Candidates</a>
            </li>
            <li>
              <a href="/addCandidate">Add Candidate</a>
            </li>
            <li>
              <a href="/createSkill">Create Skill</a>
            </li>
          </ul>
        </div>
      </div>
    </nav>
  );
};

export default Navbar;
