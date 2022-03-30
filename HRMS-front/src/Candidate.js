import React from "react";
import Image from "./user.png";

const Candidate = ({
  Id,
  FullName,
  Email,
  DateOfBirth,
  ContactNum,
  CandidateSkills,
  deleteFunction,
}) => {
  return (
    <article className="card">
      <img src={Image} alt="Image-User" />
      <h5>Full Name: {FullName}</h5>
      <br />
      <h5>Email: {Email}</h5>
      <br />
      <h5>Date Of Birth: {DateOfBirth}</h5>
      <br />
      <h5>Contact number: {ContactNum}</h5>
      <br />
      {CandidateSkills.map((skill) => {
        return (
          <div key={skill.Id}>
            <h5>{skill.SkillName}</h5>
            <button>Delete</button>
          </div>
        );
      })}
      <button
        onClick={deleteFunction(Id)}
        className="btn"
        style={{ backgroundColor: "red" }}
      >
        Delete
      </button>
    </article>
  );
};

export default Candidate;
