import React, { useState } from 'react';
import { FaHome, FaCog, FaBars, FaServer, FaBriefcase, FaPlay } from 'react-icons/fa';
import './styles.css';

export default function Sidebar() {
  const [isOpen, setIsOpen] = useState(false);

  const toggleSidebar = () => {
    setIsOpen(!isOpen);
  };

  return (
    <div className={`sidebar ${isOpen ? 'open' : ''}`}>
      <button className="toggle-btn" onClick={toggleSidebar}>
        <FaBars />
      </button>
      <nav>
        <ul>
          <li>
            <FaHome />
            <span>Home</span>
          </li>
          <li>
            <FaBriefcase />
            <span>Job</span>
          </li>
          <li>
            <FaServer />
            <span>Server</span>
          </li>
          <li>
            <FaPlay />
            <span>Execution</span>
          </li>
          <li className="config">
            <FaCog />
            <span>Configurações</span>
          </li>
        </ul>
      </nav>
    </div>
  );
}
