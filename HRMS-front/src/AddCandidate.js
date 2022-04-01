import React from "react";
import { useRef, useState, useEffect } from "react";
import HrmsApi from "./api/HrmsApi";

const Addcandidate = () => {
  const nameInputRef = useRef();
  const dateInputRef = useRef();
  const contactInputRef = useRef();
  const emailInputRef = useRef();

  const [skills, setSkills] = useState([]);

  const fetchSkills = async () => {
    try {
      let response = await HrmsApi.get("/api/skills");
      let skills = response.data;
      const expandedSkills = skills.map((skill) => {
        return { ...skill, checked: false };
      });
      setSkills(expandedSkills);
    } catch (error) {
      alert(error);
    }
  };
  useEffect(() => {
    fetchSkills();
  }, []);

  const handleCheckboxChange = (Id) => {
    setSkills(
      skills.map((skill) => {
        if (skill.Id === Id) {
          return { ...skill, checked: !skill.checked };
        }
        return skill;
      })
    );
  };

  const handleCandidateSubmit = async (e) => {
    e.preventDefault();
    const name = nameInputRef.current.value;
    const birthDate = dateInputRef.current.value;
    const contact = contactInputRef.current.value;
    const email = emailInputRef.current.value;
    const chosenSkillsExpanded = skills.filter((skill) => {
      if (skill.checked) return skill;
    });
    const chosenSkills = chosenSkillsExpanded.map((skill) => {
      return { Id: skill.Id, SkillName: skill.SkillName };
    });
    const newCandidate = {
      FullName: name,
      DateOfBirth: birthDate,
      ContactNum: contact,
      Email: email,
      CandidateSkills: chosenSkills,
    };
    try {
      let response = await HrmsApi.post("api/Candidates", newCandidate);
    } catch (error) {
      alert(error);
    }
  };

  return (
    <>
      <br />
      <form className="form" onSubmit={handleCandidateSubmit}>
        <h3>Add Candidate</h3>
        <br />
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
          <input
            type="text"
            required
            id="contactNumber"
            ref={contactInputRef}
          />
        </div>
        <div className="control">
          <label htmlFor="emailAddress">Email Address</label>
          <input type="text" required id="emailAddress" ref={emailInputRef} />
        </div>
        <div className="control">
          {skills.map((skill) => {
            return (
              <div key={skill.Id}>
                <input
                  checked={skill.checked}
                  type="checkbox"
                  onChange={() => handleCheckboxChange(skill.Id)}
                />
                <h5>{skill.SkillName}</h5>
              </div>
            );
          })}
        </div>
        <br />
        <button className="btn" type="submit">
          Submit
        </button>
      </form>
    </>
  );
};

export default Addcandidate;
