import React, { useState } from "react";
import './styles.css';
import BtnGreen from '../../../../../components/buttons/btn-green'
import InputDefault from '../../../../../components/inputs/input-default'

export default function Rabbit() {
    return (
        <div className="database-container">
            <InputDefault placeholder="Host"/>
            <InputDefault placeholder="Port"/>
            <BtnGreen className="btn-save">
                Save
            </BtnGreen>
        </div>
    );
}
