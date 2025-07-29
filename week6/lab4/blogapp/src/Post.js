// src/Post.js
import React from 'react';

function Post({ title, body }) {
  return (
    <div style={{ marginBottom: "20px" }}>
      <h3>{title}</h3>
      <p>{body}</p>
    </div>
  );
}

export default Post;
