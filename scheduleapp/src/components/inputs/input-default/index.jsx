import React from 'react';
import './styles.css';

export default function InputDefault({ placeholder, type = "text", value, onChange }) {

  return (
    <div className="input-group">
        <input
            type={type}
            placeholder={placeholder}
            value={value}
            onChange={onChange}
        />
    </div>
  );
}
