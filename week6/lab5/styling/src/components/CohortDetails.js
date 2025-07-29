import React from 'react';
import styles from './CohortDetails.module.css';

const CohortDetails = ({ name, status, participants }) => {
  const headingStyle = {
    color: status === 'ongoing' ? 'green' : 'blue'
  };

  return (
    <div className={styles.box}>
      <h3 style={headingStyle}>{name}</h3>
      <dl>
        <dt>Status:</dt>
        <dd>{status}</dd>
        <dt>Participants:</dt>
        <dd>{participants}</dd>
      </dl>
    </div>
  );
};

export default CohortDetails;
