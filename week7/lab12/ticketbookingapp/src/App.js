import React, { useState } from 'react';
import GuestPage from './components/GuestPage';
import UserPage from './components/UserPage';

function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const handleLogin = () => setIsLoggedIn(true);
  const handleLogout = () => setIsLoggedIn(false);

  const navbarStyle = {
    backgroundColor: '#007bff',
    color: 'white',
    padding: '15px 0',
    textAlign: 'center',
    fontSize: '24px',
    fontWeight: 'bold',
    fontFamily: 'Arial'
  };

  return (
    <div>
      {/* Navbar */}
      <div style={navbarStyle}>Ticket Booking App</div>

      {/* Conditional Rendering */}
      {isLoggedIn ? (
        <UserPage onLogout={handleLogout} />
      ) : (
        <GuestPage onLogin={handleLogin} />
      )}
    </div>
  );
}

export default App;
