import React, { useState } from "react";
import './styles.css';
import Layout from '../layoutCommon/';
import { FaTrash, FaEdit } from 'react-icons/fa';
import data from './vaultData';
import BtnGreen from '../../components/buttons/btn-green'
import InputDefault from '../../components/inputs/input-default/'


export default function Vault() {
    const [isEditing, setIsEditing] = useState(false); // Estado para controlar a visibilidade da div de edição
    const [editData, setEditData] = useState({ variable: '', value: '' }); // Estado para armazenar os dados que serão editados

    // Dados dos servidores
    const [dados, setDados] = useState(data); // Use o `data` importado como estado inicial

    const handleEdit = (variable, value) => {
        setEditData({ variable, value });
        setIsEditing(true);
    };

    const handleSave = () => {
        setDados((prevDados) =>
            prevDados.map((dado) =>
                dado.variable === editData.variable
                    ? { ...dado, value: editData.value }
                    : dado
            )
        );
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
                                <th>Variable</th>
                                <th>Value</th>
                            </tr>
                        </thead>
                        <tbody>
                            {dados.map((dado) => (
                                <tr key={dado.id}>
                                    <td>
                                        <FaEdit onClick={() => handleEdit(dado.variable, dado.value)} />
                                    </td>
                                    <td>
                                        <FaTrash />
                                    </td>
                                    <td>{dado.variable}</td>
                                    <td>************</td> {/* Máscara do valor */}
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
                                Variable:
                                <InputDefault
                                    className="input-server"
                                    type="text"
                                    value={editData.variable}
                                    readOnly
                                />
                            </label>
                            <label className="lb-ip">
                                Value:
                                <InputDefault
                                    className="input-ip"
                                    type="text"
                                    value={editData.value} // Valor verdadeiro aparece aqui
                                    onChange={(e) =>
                                        setEditData({ ...editData, value: e.target.value })
                                    }
                                />
                            </label>
                        </div>
                        <div className="div-buttons">
                            <button className="btn-close" onClick={() => setIsEditing(false)}>
                                Close
                            </button>
                            <BtnGreen className="btn-save" onClick={handleSave}>
                                Save
                            </BtnGreen>
                        </div>
                    </div>
                )}
            </div>
        </Layout>
    );
}
