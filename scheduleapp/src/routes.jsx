import React from "react";
import { Routes, Route } from "react-router-dom";

import Login from './pages/Login';
import Home from "./pages/home";
import Server from "./pages/server/";


export default function AppRoutes() {
    return (
        <Routes>
            <Route path="/" element={<Login />} />
            <Route path="/home" element={<Home />} />
            <Route path="/server" element={<Server />} />
        </Routes>
    );
}
