import React, { Component } from 'react';
import classes from './PersonCard.module.css';

class PersonCard extends Component {
    render() {
        const { firstName, lastName, age, hairColor } = this.props;
        return (
            <div className={classes.card}>
                <div className={classes.content}>
                    <h1>{ lastName }, { firstName }</h1>
                    <p>Age: { age }</p>
                    <p>Hair Color: { hairColor }</p>
                </div>
            </div>
        );
    }
}

export default PersonCard;