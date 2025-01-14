import React, { useState } from "react";
import './styles.css';
import BtnGreen from '../../../../../components/buttons/btn-green'

export default function DataBase() {
    return (
        <div className="database-container">
            <input placeholder="Server"/>
            <input placeholder="Port"/>
            <input placeholder="Database"/>
            <input placeholder="User"/>
            <input placeholder="Password"/>
            <BtnGreen className="btn-save">
                Save
            </BtnGreen>
        </div>
    );
}
