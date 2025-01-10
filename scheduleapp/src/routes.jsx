import React from "react";
import { Routes, Route } from "react-router-dom";

import Login from './pages/Login';
import Home from "./pages/home";
import Job from "./pages/job";
import Server from "./pages/server";
import Vault from "./pages/vault";
import Execution from "./pages/execution";
import Settings from "./pages/settings";



export default function AppRoutes() {
    return (
        <Routes>
            <Route path="/" element={<Login />} />
            <Route path="/home" element={<Home />} />
            <Route path="/server" element={<Server />} />
            <Route path="/job" element={<Job />} />
            <Route path="/vault" element={<Vault />} />
            <Route path="/execution" element={<Execution />} />
            <Route path="/settings" element={<Settings />} />
        </Routes>
    );
}
