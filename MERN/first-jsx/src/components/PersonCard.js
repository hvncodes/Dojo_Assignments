// import React, { Component } from 'react';
import React, { useState } from 'react';
import classes from './PersonCard.module.css';

// class PersonCard extends Component {
//     constructor(props) {
//         super(props);
//         this.state = {
//             age: props.person.age
//         };
//     }
    // render() {
    //     const { firstName, lastName, hairColor } = this.props.person;
    //     return (
    //         <div className={classes.card}>
    //             <div className={classes.content}>
    //                 <h1>{ lastName }, { firstName }</h1>
    //                 <p>Age: { this.state.age }</p>
    //                 <p>Hair Color: { hairColor }</p>
    //                 <button onClick={ this.agePlusOne }>Birthday Button for { firstName } { lastName }</button>
    //             </div>
    //         </div>
    //     );
    // }

//     agePlusOne = () => {
//         //parseInt(this.state.age) + 1;
//         // let currentAgePlusOne = this.state.age + 1
//         this.setState({ age: this.state.age + 1 });
//     }
// }

const PersonCard = props => {
    const [state, setState] = useState({
        age: props.person.age
    });

    const agePlusOne = () => {
        setState({
            age: state.age + 1
        });
    }

    const { firstName, lastName, hairColor } = props.person;
    return(
        <div className={ classes.card }>
            <div className={ classes.content }>
                <h1>{ lastName }, { firstName }</h1>
                <p>Age: { state.age }</p>
                <p>Hair Color: { hairColor }</p>
                <button onClick={ agePlusOne }>Birthday Button for { firstName } { lastName }</button>
            </div>
        </div>
    );
}

export default PersonCard;