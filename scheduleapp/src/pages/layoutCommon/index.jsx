import React from 'react';
import Sidebar from '../../components/sidebar/';
import Footer from '../../components/footer/';
import './styles.css'; 

export default function Layout({ children }) {
  return (
    <div className="layout">
      <Sidebar />
      <main className="content">{children}</main>
      <Footer />
    </div>
  );
}
