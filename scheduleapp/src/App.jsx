// App.js
import React from 'react';
import Routes from './routes'; // Importando as rotas
import './global.css'; // CSS global

export default function App() {
    return (
        <Routes /> // Não precisamos do BrowserRouter aqui, pois ele já está em routes.js
    );
}
