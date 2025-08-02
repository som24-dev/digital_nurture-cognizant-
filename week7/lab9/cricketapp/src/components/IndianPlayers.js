import React from 'react';

const IndianPlayers = () => {
  // Destructuring odd & even players
  const team = ['Virat', 'Rohit', 'Rahul', 'Jadeja', 'Bumrah', 'Pant'];
  const [odd1, even1, odd2, even2, odd3, even3] = team;

  // Arrays and merging
  const T20players = ['Hardik', 'Surya', 'Ishan'];
  const RanjiTrophyPlayers = ['Pujara', 'Rahane', 'Saha'];
  const allPlayers = [...T20players, ...RanjiTrophyPlayers];

  return (
    <div>
      <h2>Odd Team Players:</h2>
      <ul>
        <li>{odd1}</li>
        <li>{odd2}</li>
        <li>{odd3}</li>
      </ul>

      <h2>Even Team Players:</h2>
      <ul>
        <li>{even1}</li>
        <li>{even2}</li>
        <li>{even3}</li>
      </ul>

      <h2>Merged Players (T20 + Ranji):</h2>
      <ul>
        {allPlayers.map((p, index) => (
          <li key={index}>{p}</li>
        ))}
      </ul>
    </div>
  );
};

export default IndianPlayers;
