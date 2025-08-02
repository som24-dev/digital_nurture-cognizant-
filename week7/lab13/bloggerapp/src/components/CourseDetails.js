import React from 'react';

function CourseDetails() {
  const courses = [
    { name: 'React for Beginners', instructor: 'Som', duration: '30 hours' },
    { name: 'Advanced JavaScript', instructor: 'Akash', duration: '40 hours' },
    { name: 'Full Stack Development', instructor: 'Sans', duration: '50 hours' }
  ];

  return (
    <div>
      <h2>Available Courses</h2>
      <ul style={{ listStyleType: 'none', padding: 0 }}>
        {courses.map((course, index) => (
          <li key={index} style={{ marginBottom: '10px' }}>
            <strong>{course.name}</strong> by {course.instructor} - <em>{course.duration}</em>
          </li>
        ))}
      </ul>
    </div>
  );
}

export default CourseDetails;
