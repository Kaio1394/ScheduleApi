import React from "react";
import './styles.css'

import Sidebar from '../../components/sidebar/';

export default function Home(){
    return (
        <div className="home-container">
            <div className="sidebar-container">
                <Sidebar />
            </div>
        </div>
    );
}