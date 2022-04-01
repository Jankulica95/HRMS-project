import { useState, useRef } from "react";
import HrmsApi from "./api/HrmsApi";

const CreateSkill = () => {
  const skillInputRef = useRef();

  const handleSkillSubmit = async (e) => {
    e.preventDefault();
    const skillName = skillInputRef.current.value;
    const item = { SkillName: skillName };
    try {
      let response = await HrmsApi.post("api/Skills", item);
    } catch (error) {
      console.log(error);
    }
  };

  return (
    <div>
      <form className="form" onSubmit={handleSkillSubmit}>
        <h3>Create Skill</h3>
        <br />
        <div className="control">
          <label htmlFor="skillName">Skill Name</label>
          <input type="text" required id="skillName" ref={skillInputRef} />
        </div>
        <input className="btn" type="submit" value="Create" />
      </form>
    </div>
  );
};

export default CreateSkill;
