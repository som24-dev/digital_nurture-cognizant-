import React from 'react';

function BookDetails() {
  const books = [
    { title: 'Mastering React', author: 'Som', price: '₹700' },
    { title: 'JavaScript Deep Dive', author: 'Akash', price: '₹500' },
    { title: 'Frontend with HTML & CSS', author: 'Sans', price: '₹400' }
  ];

  return (
    <div>
      <h2>Books Collection</h2>
      <ul style={{ listStyleType: 'none', padding: 0 }}>
        {books.map((book, index) => (
          <li key={index} style={{ marginBottom: '10px' }}>
            <strong>{book.title}</strong> by {book.author} - <em>{book.price}</em>
          </li>
        ))}
      </ul>
    </div>
  );
}

export default BookDetails;
