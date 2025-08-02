import React, { useState } from 'react';
import CurrencyConvertor from './components/CurrencyConvertor';

function App() {
  const [count, setCount] = useState(0);

  // Styles
  const buttonStyle = {
    margin: '10px',
    padding: '10px 20px',
    border: 'none',
    borderRadius: '5px',
    backgroundColor: '#007bff',
    color: 'white',
    fontSize: '16px',
    cursor: 'pointer'
  };

  const containerStyle = {
    textAlign: 'center',
    marginTop: '30px',
    fontFamily: 'Arial'
  };

  // Event functions
  const increment = () => {
    setCount(count + 1);
    sayHello();
  };

  const sayHello = () => {
    alert("Hello! This is a static message.");
  };

  const decrement = () => {
    setCount(count - 1);
  };

  const sayWelcome = (msg) => {
    alert(msg);
  };

  const handleSyntheticEvent = (e) => {
    alert("I was clicked");
    console.log("Synthetic Event Object:", e);
  };

  return (
    <div style={containerStyle}>
      <h1>Event Examples App</h1>
      <h2>Counter: {count}</h2>

      <button style={buttonStyle} onClick={increment}>Increment</button>
      <button style={{ ...buttonStyle, backgroundColor: 'red' }} onClick={decrement}>Decrement</button>
      <br />

      <button
        style={{ ...buttonStyle, backgroundColor: 'green' }}
        onClick={() => sayWelcome("Welcome to the Event Handling App!")}
      >
        Say Welcome
      </button>
      <br />

      <button
        style={{ ...buttonStyle, backgroundColor: 'orange' }}
        onClick={handleSyntheticEvent}
      >
        OnPress Synthetic Event
      </button>

      <CurrencyConvertor />
    </div>
  );
}

export default App;
