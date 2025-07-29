import React from 'react';
import CohortDetails from './components/CohortDetails';

function App() {
  return (
    <div style={{ textAlign: 'center' }}>
      <CohortDetails name="React Bootcamp" status="ongoing" participants={25} />
      <CohortDetails name="Node.js Workshop" status="completed" participants={18} />
    </div>
  );
}

export default App;
