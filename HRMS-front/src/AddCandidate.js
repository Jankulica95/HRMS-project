import React from "react";
import { useRef, useState, useEffect } from "react";
import HrmsApi from "./api/HrmsApi";

const Addcandidate = () => {
  const nameInputRef = useRef();
  const dateInputRef = useRef();
  const contactInputRef = useRef();
  const emailInputRef = useRef();
  //   const skillsRef = ????

  const [skills, setSkills] = useState([]);

  const fetchSkills = async () => {
    try {
      let response = await HrmsApi.get("/api/skills");
      let items = response.data;
      setSkills(items);
      console.log(items);
    } catch (error) {
      console.log(error);
    }
  };

  useEffect(() => {
    fetchSkills();
  }, []);

  return (
    <form className="form">
      <div className="control">
        <label htmlFor="fullName">Full Name</label>
        <input type="text" required id="fullName" ref={nameInputRef} />
      </div>
      <div className="control">
        <label htmlFor="dateOfBirth">Date Of Birth</label>
        <input type="text" required id="dateOfBirth" ref={dateInputRef} />
      </div>
      <div className="control">
        <label htmlFor="contactNumber">Contact Number</label>
        <input type="text" required id="contactNumber" ref={contactInputRef} />
      </div>
      <div className="control">
        <label htmlFor="emailAddress">Email Address</label>
        <input type="text" required id="emailAddress" ref={emailInputRef} />
      </div>
      <div className="control">
        {skills.map((skill) => {
          return (
            <div key={skill.Id}>
              <input type="checkbox" />
              <h5>{skill.SkillName}</h5>
            </div>
          );
        })}
      </div>
    </form>
  );
};

export default Addcandidate;
