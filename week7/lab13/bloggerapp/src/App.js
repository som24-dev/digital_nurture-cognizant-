import React, { useState } from 'react';
import BookDetails from './components/BookDetails';
import BlogDetails from './components/BlogDetails';
import CourseDetails from './components/CourseDetails';

function App() {
  const [view, setView] = useState('book');
  const [showWelcome, setShowWelcome] = useState(true);

  const renderComponent = () => {
    switch (view) {
      case 'book':
        return <BookDetails />;
      case 'blog':
        return <BlogDetails />;
      case 'course':
        return <CourseDetails />;
      default:
        return <h2>Select a section to view details</h2>;
    }
  };

  const buttonStyle = {
    margin: '10px',
    padding: '10px 20px',
    border: 'none',
    borderRadius: '5px',
    cursor: 'pointer',
    fontSize: '16px',
    color: 'white'
  };

  return (
    <div style={{ textAlign: 'center', fontFamily: 'Arial' }}>
      <h1>Blogger App</h1>

      {/* Buttons to switch between sections */}
      <button style={{ ...buttonStyle, backgroundColor: '#007bff' }} onClick={() => setView('book')}>
        Show Books
      </button>
      <button style={{ ...buttonStyle, backgroundColor: '#28a745' }} onClick={() => setView('blog')}>
        Show Blogs
      </button>
      <button style={{ ...buttonStyle, backgroundColor: '#ffc107' }} onClick={() => setView('course')}>
        Show Courses
      </button>

      <hr />

      {/* Conditional Rendering Examples */}
      {showWelcome ? <p>Welcome to BloggerApp!</p> : <p>Thanks for visiting!</p>}
      {showWelcome && <p>Explore books, blogs, and courses by Som, Akash, and Sans.</p>}
      <button
        style={{ ...buttonStyle, backgroundColor: 'purple' }}
        onClick={() => setShowWelcome(!showWelcome)}
      >
        Toggle Welcome
      </button>

      <hr />

      {/* Dynamic Rendering */}
      {renderComponent()}
    </div>
  );
}

export default App;
