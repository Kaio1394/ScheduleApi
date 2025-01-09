// Sidebar.js
import React, { useState } from 'react';
import { FaHome, FaCog, FaBars, FaServer, FaBriefcase, FaPlay, FaLock } from 'react-icons/fa';
import { useNavigate } from 'react-router-dom';  // Usando o hook useNavigate
import './styles.css';

export default function Sidebar() {
  const [isOpen, setIsOpen] = useState(false);
  const navigate = useNavigate();  // Instanciando o hook

  const toggleSidebar = () => {
    setIsOpen(!isOpen);
  };

  // Função para navegação
  const handleClick = (route) => {
    navigate(route);  // Navega para a rota especificada
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
            <span onClick={() => handleClick('/home')}>Home</span> 
          </li>
          <li>
            <FaBriefcase />
            <span onClick={() => handleClick('/server')}>Server</span>  
          </li>
          <li>
            <FaPlay />
            <span>Execution</span>
          </li>
          <li>
            <FaLock />
            <span >Vault</span>
          </li>
          <li className="config">
            <FaCog />
            <span >Settings</span>
          </li>
        </ul>
      </nav>
    </div>
  );
}
