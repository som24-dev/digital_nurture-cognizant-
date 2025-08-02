import React from 'react';

function UserPage({ onLogout }) {
  return (
    <div style={{ textAlign: 'center', marginTop: '40px', fontFamily: 'Arial', fontSize: '18px' }}>
      <h1 style={{ fontSize: '32px' }}>Welcome Back, User!</h1>
      <p>Now you can book tickets:</p>
      <ul style={{ listStyleType: 'none', padding: 0 }}>
        <li>Flight 101 - Book Now</li>
        <li>Flight 202 - Book Now</li>
        <li>Flight 303 - Book Now</li>
      </ul>
      <button
        onClick={onLogout}
        style={{
          padding: '12px 25px',
          marginTop: '20px',
          backgroundColor: 'red',
          color: 'white',
          fontSize: '16px',
          border: 'none',
          borderRadius: '6px',
          cursor: 'pointer'
        }}
      >
        Logout
      </button>
    </div>
  );
}

export default UserPage;
