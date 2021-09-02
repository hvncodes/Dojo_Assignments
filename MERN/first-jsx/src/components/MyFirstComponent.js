import React, { Component } from 'react';

class MyFirstComponent extends Component {
    render() {
        return (
            <>
            <div>
                We are in MyFirstComponent!
            </div>
            <h1>Hello Dojo!</h1>
            <h2>Things I need to do:</h2>
            <ul>
                <li>Learn React</li>
                <li>Climb Mt. Everest</li>
                <li>Run a marathon</li>
                <li>Feed the dogs</li>
            </ul>
            </>
        );
    }
}

export default MyFirstComponent;