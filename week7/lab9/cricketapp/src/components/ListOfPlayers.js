import React from 'react';

const ListOfPlayers = () => {
  // Array of players
  const players = [
    { name: 'Virat Kohli', score: 90 },
    { name: 'Rohit Sharma', score: 85 },
    { name: 'KL Rahul', score: 60 },
    { name: 'Shreyas Iyer', score: 40 },
    { name: 'Hardik Pandya', score: 95 },
    { name: 'Ravindra Jadeja', score: 30 },
    { name: 'Rishabh Pant', score: 75 },
    { name: 'Suryakumar Yadav', score: 65 },
    { name: 'Jasprit Bumrah', score: 80 },
    { name: 'Bhuvneshwar Kumar', score: 50 },
    { name: 'Yuzvendra Chahal', score: 20 }
  ];

  // Filter using arrow function
  const topPlayers = players.filter(p => p.score >= 70);

  return (
    <div>
      <h2>All Players:</h2>
      <ul>
        {players.map((p, index) => (
          <li key={index}>{p.name} - {p.score}</li>
        ))}
      </ul>

      <h2>Top Players (Score ≥ 70):</h2>
      <ul>
        {topPlayers.map((p, index) => (
          <li key={index}>{p.name} - {p.score}</li>
        ))}
      </ul>
    </div>
  );
};

export default ListOfPlayers;
