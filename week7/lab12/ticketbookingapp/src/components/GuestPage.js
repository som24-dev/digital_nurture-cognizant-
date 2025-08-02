import React from 'react';

function GuestPage({ onLogin }) {
  return (
    <div style={{ textAlign: 'center', marginTop: '40px', fontFamily: 'Arial', fontSize: '18px' }}>
      <h1 style={{ fontSize: '32px' }}>Welcome Guest</h1>
      <p>Browse available flights below:</p>
      <ul style={{ listStyleType: 'none', padding: 0 }}>
        <li>Flight 101 - Delhi → Mumbai - ₹5000</li>
        <li>Flight 202 - Bangalore → Chennai - ₹3500</li>
        <li>Flight 303 - Kolkata → Pune - ₹4500</li>
      </ul>
      <button
        onClick={onLogin}
        style={{
          padding: '12px 25px',
          marginTop: '20px',
          backgroundColor: 'green',
          color: 'white',
          fontSize: '16px',
          border: 'none',
          borderRadius: '6px',
          cursor: 'pointer'
        }}
      >
        Login to Book Tickets
      </button>
    </div>
  );
}

export default GuestPage;
