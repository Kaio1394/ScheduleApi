import React, { useState } from "react";
import './styles.css';
import BtnGreen from '../../../../../components/buttons/btn-green'
import InputDefault from '../../../../../components/inputs/input-default/'

export default function DataBase() {
    return (
        <div className="database-container">
            <InputDefault placeholder="Server"/>
            <InputDefault placeholder="Port"/>
            <InputDefault placeholder="Database"/>
            <InputDefault placeholder="User"/>
            <InputDefault placeholder="Password"/>
            <BtnGreen className="btn-save">
                Save
            </BtnGreen>
        </div>
    );
}
