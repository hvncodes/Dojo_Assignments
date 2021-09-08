import react from 'react';

const BoxDisplay = (props) => {
    const divStyle = {
        backgroundColor: props.box.color,
        width: props.box.size + 'px',
        height: props.box.size + 'px',
    };
    return (
        <div style={ divStyle } id={ props.id }>
            { props.box.color }<br />
            { props.box.size } px<br />
        </div>
    )
}

export default BoxDisplay;