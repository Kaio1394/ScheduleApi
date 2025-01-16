import React, { useState } from "react";
import './styles.css';
import BtnGreen from '../../../../../components/buttons/btn-green';
import InputDefault from '../../../../../components/inputs/input-default/';
import ProgressCircularBar from "../../../../../components/progress-circular-bar";

export default function DataBase() {
    const [isLoading, setIsLoading] = useState(false);

    const handleTestClick = () => {
        setIsLoading(true);
        setTimeout(() => setIsLoading(false), 3000); // Simula o fim do carregamento
    };

    return (
        <div className="database-container">
            <InputDefault placeholder="Server" />
            <InputDefault placeholder="Port" />
            <InputDefault placeholder="Database" />
            <InputDefault placeholder="User" />
            <InputDefault placeholder="Password" />
            <div className="button-container">
                <BtnGreen className="btn-test" onClick={handleTestClick}>
                    Test
                </BtnGreen>
                <BtnGreen className="btn-save">
                    Save
                </BtnGreen>
            </div>
            {isLoading && (
                <ProgressCircularBar/>
            )}
        </div>
    );
}
