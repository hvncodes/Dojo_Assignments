import react, { useState } from 'react';

const BoxDisplay = (props) => {
    return (
        <div>
            This is a div that will be colored:<br />
            { props.box.color }<br />
            and have width and length:<br />
            { props.box.size } px<br />
            later :^)
        </div>
    )
}

export default BoxDisplay;