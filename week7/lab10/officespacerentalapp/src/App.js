import React from 'react';

function App() {
  // Office details
  const offices = [
    { name: 'Skyline Tower', rent: 55000, address: 'MG Road, Bangalore', image: '/images/img1.avif' },
    { name: 'Tech Park View', rent: 75000, address: 'Hitech City, Hyderabad', image: '/images/img2.jpg' },
    { name: 'City Center Hub', rent: 60000, address: 'Connaught Place, Delhi', image: '/images/img3.jpg' }
  ];

  // JSX heading
  const heading = <h1>Office Space Rental App</h1>;

  return (
    <div style={{ textAlign: 'center', fontFamily: 'Arial' }}>
      {heading}

      {/* Loop through the offices list */}
      {offices.map((office, index) => (
        <div key={index} style={{ border: '1px solid #ccc', margin: '20px auto', padding: '10px', width: '300px' }}>
          <h2>{office.name}</h2>
          <img src={office.image} alt={office.name} style={{ width: '100%', borderRadius: '5px' }} />
          <p><strong>Address:</strong> {office.address}</p>
          <p style={{ color: office.rent > 60000 ? 'green' : 'red' }}>
            <strong>Rent:</strong> ₹{office.rent}
          </p>
        </div>
      ))}
    </div>
  );
}

export default App;
