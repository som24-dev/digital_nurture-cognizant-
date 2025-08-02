import React, { useState } from 'react';

function CurrencyConvertor() {
  const [rupees, setRupees] = useState('');
  const [euros, setEuros] = useState('');

  const handleSubmit = (e) => {
    e.preventDefault(); // Prevent page reload
    const conversionRate = 0.011; // Example conversion
    setEuros((rupees * conversionRate).toFixed(2));
  };

  return (
    <div style={{ marginTop: '20px' }}>
      <h2>Currency Convertor</h2>
      <form onSubmit={handleSubmit}>
        <label>Enter amount in INR: </label>
        <input
          type="number"
          value={rupees}
          onChange={(e) => setRupees(e.target.value)}
        />
        <button type="submit">Convert</button>
      </form>
      {euros && <p>{rupees} INR = {euros} EUR</p>}
    </div>
  );
}

export default CurrencyConvertor;
