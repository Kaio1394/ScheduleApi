import React, { useState } from "react";
import './styles.css'
import Layout from '../layoutCommon/'; 
import DataBase from './childrens/pages/dataBase'

export default function Settings(){
    const [activeTab, setActiveTab] = useState(0);
    const tabs = [
        { title: "Data Base", content: <DataBase/> },
        { title: "Rabbit", content: <DataBase/> },
        { title: "Logs", content: <DataBase/> },
    ];

    return (
        <Layout>
            <div className="tabs-container">
            {/* Cabeçalhos das Abas */}
            <div className="tabs-header">
                {tabs.map((tab, index) => (
                    <button
                        key={index}
                        className={`tab-button ${activeTab === index ? "active" : ""}`}
                        onClick={() => setActiveTab(index)}
                    >
                        {tab.title}
                    </button>
                ))}
            </div>

            {/* Conteúdo da Aba Ativa */}
            <div className="tabs-content">
                {tabs[activeTab].content}
            </div>
        </div>       
        </Layout>
    );
}