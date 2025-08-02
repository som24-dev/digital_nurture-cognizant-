import React from 'react';

function BlogDetails() {
  const blogs = [
    { title: 'React Performance Tips', author: 'Som', published: 'Today' },
    { title: 'Async JS Simplified', author: 'Akash', published: 'Yesterday' },
    { title: 'CSS Tricks for Beginners', author: 'Sans', published: 'Last Week' }
  ];

  return (
    <div>
      <h2>Tech Blogs</h2>
      <ul style={{ listStyleType: 'none', padding: 0 }}>
        {blogs.map((blog, index) => (
          <li key={index} style={{ marginBottom: '10px' }}>
            <strong>{blog.title}</strong> by {blog.author} - <em>{blog.published}</em>
          </li>
        ))}
      </ul>
    </div>
  );
}

export default BlogDetails;
