// Sidebar.js
import React, { useState } from 'react';
import { FaHome, FaCog, FaBars, FaServer, FaBriefcase, FaPlay, FaLock } from 'react-icons/fa';
import { useNavigate } from 'react-router-dom'; // Usando o hook useNavigate
import './styles.css';

export default function Sidebar() {
  const [isOpen, setIsOpen] = useState(false);
  const navigate = useNavigate(); // Instanciando o hook
  const [activeRoute, setActiveRoute] = useState('/home'); // Rota ativa

  const toggleSidebar = () => {
    setIsOpen(!isOpen);
  };

  // Função para navegação
  const handleNavigation = (route) => {
    setActiveRoute(route); // Atualiza a rota ativa
    navigate(route); // Navega para a rota especificada
  };

  const menuItems = [
    { icon: <FaHome />, label: 'Home', route: '/home' },
    { icon: <FaBriefcase />, label: 'Job', route: '/job' },
    { icon: <FaServer />, label: 'Server', route: '/server' },
    { icon: <FaPlay />, label: 'Execution', route: '/execution' },
    { icon: <FaLock />, label: 'Vault', route: '/vault' },
    { icon: <FaCog />, label: 'Settings', route: '/settings' },
  ];

  return (
    <div className={`sidebar ${isOpen ? 'open' : ''}`}>
      <button className="toggle-btn" onClick={toggleSidebar}>
        <FaBars />
      </button>
      <nav>
        <ul>
          {menuItems.map((item) => (
            <li
              key={item.route}
              className={activeRoute === item.route ? 'active' : ''}
              onClick={() => handleNavigation(item.route)}
            >
              {item.icon}
              <span>{item.label}</span>
            </li>
          ))}
        </ul>
      </nav>
    </div>
  );
}
