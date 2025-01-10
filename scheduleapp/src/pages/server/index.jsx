import React from "react";
import './styles.css'
import Layout from '../layoutCommon/'; 

export default function Server(){

    const dados = [
        { id: 1, nome: 'João', idade: 25 },
        { id: 2, nome: 'Maria', idade: 30 },
        { id: 3, nome: 'Pedro', idade: 22 },
      ];

    return (
        <Layout>
            <div className="home-content">
                <table border="1">
                    <thead>
                        <tr>
                        <th>ID</th>
                        <th>Nome</th>
                        <th>Idade</th>
                        </tr>
                    </thead>
                    <tbody>
                        {dados.map((dado) => (
                        <tr key={dado.id}>
                            <td>{dado.id}</td>
                            <td>{dado.nome}</td>
                            <td>{dado.idade}</td>
                        </tr>
                        ))}
                    </tbody>
                </table>
            </div>
        </Layout>
    );
}