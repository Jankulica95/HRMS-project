import { useState, useEffect } from "react";
import HrmsApi from "./api/HrmsApi";
import Candidate from "./Candidate";

function App() {
  const [candidates, setCandidates] = useState([]);
  const [loading, setLoading] = useState(true);

  const fetchCandidates = async () => {
    try {
      let response = await HrmsApi.get("/api/candidates");
      let Items = response.data;
      setCandidates(Items);
      setLoading(false);
      console.log(Items);
    } catch (error) {
      console.log("Error occured trying to fetch items");
    }
  };

  const deleteCandidate = (Id) => async () => {
    try {
      let response = await HrmsApi.delete(`/api/candidates/${Id}`);
      console.log("Brisanje je uspelo!");
    } catch (error) {
      console.log(error);
    }
  };

  useEffect(() => {
    fetchCandidates();
  }, []);

  return (
    <main>
      <div className="section-title">
        <h1>{loading ? "Loading..." : "Job Candidates"}</h1>
        <div className="underline"></div>
      </div>
      <section className="followers">
        <div className="container">
          {candidates.map((person) => {
            return (
              <Candidate
                key={person.Id}
                {...person}
                deleteFunction={deleteCandidate}
              />
            );
          })}
        </div>
      </section>
    </main>
  );
}

export default App;
