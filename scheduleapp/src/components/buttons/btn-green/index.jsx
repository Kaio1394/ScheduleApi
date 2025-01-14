// Sidebar.js
import React, { useState } from 'react';
import './styles.css';

export default function BtnGreen({ onClick, children }) {

  return (
    <button className="btn-save" onClick={onClick}>
        {children || "Save"}
    </button>
  );
}
