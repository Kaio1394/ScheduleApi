import React from 'react';
import Sidebar from '../../components/sidebar/';
import './styles.css'; 

export default function Layout({ children }) {
  return (
    <div className="layout">
      <Sidebar />
      <main className="content">{children}</main>
    </div>
  );
}
