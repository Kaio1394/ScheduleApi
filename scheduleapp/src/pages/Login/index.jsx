import React, { useState } from "react";
import './styles.css';
import { useNavigate } from "react-router-dom";
import ProgressCircularBar from "../../components/progress-circular-bar";

export default function Login() {
    const navigate = useNavigate();
    const [Isloading, setIsLoading] = useState(false);

    const handleLogin = (event) => {
        event.preventDefault(); 
        setIsLoading(true);

        setTimeout(() => {
            setIsLoading(false); 
            navigate("/home"); 
        }, 3000);
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
            {Isloading &&
                <ProgressCircularBar/>
            }
        </div>
    );
}
