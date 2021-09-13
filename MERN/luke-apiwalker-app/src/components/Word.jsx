import React from 'react';
import { useParams } from "react-router";

const Word = (props) => {
    const { word, textColor, bgColor } = useParams();
    console.log(word);
    console.log(textColor);
    console.log(bgColor);
    const text = isNaN(+word) ? "word" : "number";
    
    const h1Style = {
        color: textColor || "#007bff",
        backgroundColor: bgColor,
        border: word === "watermelon" ? "5px solid #71A95A" : "none"
    }
    return (
        <h1 style={ h1Style }>The { text } is: { word }</h1>
    );
}

export default Word;