import React, { useState } from "react";
import './styles.css';
import Layout from '../layoutCommon/'; 
import { FaTrash, FaEdit } from 'react-icons/fa';
import InputDefault from '../../components/inputs/input-default/'


export default function Server() {
    const [isEditing, setIsEditing] = useState(false); // Estado para controlar a visibilidade da div de edição
    const [editData, setEditData] = useState({ tagName: '', ip: '' }); // Estado para armazenar os dados do servidor que serão editados

    // Dados dos servidores
    const dados = [
        { id: 1, edit: <FaEdit onClick={() => handleEdit('Server_1', '192.168.1.1')}/>, delete: <FaTrash />, tagName: 'Server_1', ip: "192.168.1.1" },
        { id: 2, edit: <FaEdit onClick={() => handleEdit('Server_2', '192.168.1.2')}/>, delete: <FaTrash />, tagName: 'Server_2', ip: "192.168.1.2" },
        { id: 3, edit: <FaEdit onClick={() => handleEdit('Server_3', '192.168.1.4')}/>, delete: <FaTrash />, tagName: 'Server_3', ip: "192.168.1.4" },
    ];

    const handleEdit = (tagName, ip) => {
        setEditData({ tagName, ip }); 
        setIsEditing(true); 
    };

    const closeEdit = () => {
        setIsEditing(false);
    };

    return (
        <Layout>
            <div className="container-content">
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

                {/* Div de Edição, visível quando isEditing for true */}
                {isEditing && (
                    <div className="edit-container">
                        <div className="div-edit">
                            <label className="lb-server">
                                TagName:
                                <InputDefault className="input-server"
                                    type="text"
                                    value={editData.tagName}
                                    onChange={(e) => setEditData({ ...editData, tagName: e.target.value })}
                                />
                            </label>
                            <label className="lb-ip">
                                IP Address:
                                <InputDefault className="input-ip"
                                    type="text"
                                    value={editData.ip}
                                    onChange={(e) => setEditData({ ...editData, ip: e.target.value })}
                                />
                        </label>
                        </div>
                        <div className="div-buttons">
                            <button className="btn-close" onClick={closeEdit}>Close</button>
                            <button className="btn-save" onClick={() => console.log('Save changes:', editData)}>Save</button>
                        </div>
                    </div>
                )}
            </div>
        </Layout>
    );
}
