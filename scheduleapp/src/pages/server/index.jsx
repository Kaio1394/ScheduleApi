import React from "react";
import './styles.css'
import Layout from '../layoutCommon/'; 
import { FaTrash, FaEdit } from 'react-icons/fa';

export default function Server(){

    const dados = [
        { edit: <FaEdit/>, delete: <FaTrash />, tagName: 'Server_1', ip: "192.168.1.1" },
        { edit: <FaEdit/>, delete: <FaTrash />, tagName: 'Server_2', ip: "192.168.1.2" },
        { edit: <FaEdit/>, delete: <FaTrash />, tagName: 'Server_3', ip: "192.168.1.4" },
      ];

    return (
        <Layout>
            <div className="home-content">
                <div className="container-table">
                <table border="1">
                    <thead>
                        <tr>
                        <th>Edit</th>
                        <th>Delete</th>
                        <th>TagName</th>
                        <th>IP Address</th>
                        </tr>
                    </thead>
                    <tbody>
                        {dados.map((dado) => (
                        <tr key={dado.id}>
                            <td>{dado.edit}</td>
                            <td>{dado.delete}</td>
                            <td>{dado.tagName}</td>
                            <td>{dado.ip}</td>
                        </tr>
                        ))}
                    </tbody>
                </table>
                </div>
            </div>
        </Layout>
    );
}