import { React } from "react";
import './styles.css';

export default function Login(){
    return (
        <div className="login-container">
            <section className="form">
                <form>
                    <input placeholder="UserName or Email"/>
                    <input type="password" placeholder="Password"/>
                    <button className="button" type="submit">Login</button>
                    <a className="forgot-password" >Forgot Password?</a>
                    <button className="button" id="sign-up" type="submit">Sign Up</button>
                </form>
            </section>            
        </div>
    );
}