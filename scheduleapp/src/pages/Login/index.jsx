import React from "react";
import './styles.css';
import { useNavigate } from "react-router-dom";

export default function Login() {
    const navigate = useNavigate();

    const handleLogin = (event) => {
        event.preventDefault(); // Impede o envio padrão do formulário
        navigate("/home"); // Redireciona para a página Home
    };

    return (
        <div className="login-container">
            <section className="form">
                <form onSubmit={handleLogin}>
                    <input placeholder="UserName or Email" />
                    <input type="password" placeholder="Password" />
                    <button className="button" type="submit">
                        Login
                    </button>
                    <a className="forgot-password">Forgot Password?</a>
                    <button className="button" id="sign-up" type="button">
                        Sign Up
                    </button>
                </form>
            </section>
        </div>
    );
}
