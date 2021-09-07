import React, { useState } from 'react';

const Form = props => {
    const [firstname, setFirstname] = useState("");
    const [lastname, setLastname] = useState("");
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");
    const [confirmpassword, setConfirmpassword] = useState("");

    const [firstnameError, setFirstnameError] = useState("");
    const [lastnameError, setLastnameError] = useState("");
    const [emailError, setEmailError] = useState("");
    const [passwordError, setPasswordError] = useState("");
    const [confirmpasswordError, setConfirmpasswordError] = useState("");

    // pw match error
    const [matchError, setMatchError] = useState("");
    // form submission feedback
    const [hasBeenSubmitted, setHasBeenSubmitted] = useState(false);

    const createUser = (e) => {
        e.preventDefault();
        const newUser = { firstname, lastname, email, password, confirmpassword };
        console.log("Welcome", newUser);
        setHasBeenSubmitted( true );
        setFirstname("");
        setLastname("");
        setEmail("");
        setPassword("");
        setConfirmpassword("");
        setMatchError("");
    };

    const formMessage = () => {
        if( hasBeenSubmitted ) {
            return "Thank you for submitting the form!";
        } else {
            return "Welcome, please submit the form";
        }
        // under form tag, alternatively, we could do this
        // {
        //     hasBeenSubmitted ? 
        //     <h3>Thank you for submitting the form!</h3> :
        //     <h3>Welcome, please submit the form.</h3> 
        // }
    };

    const handleFirstname = (e) => {
        setFirstname(e.target.value);
        if(e.target.value.length < 1) {
            setFirstnameError("First Name is required!");
        } else if(e.target.value.length < 2) {
            setFirstnameError("First Name must be 2 characters or longer!");
        } else {
            setFirstnameError("");
        }
    }

    const handleLastname = (e) => {
        setLastname(e.target.value);
        if(e.target.value.length < 1) {
            setLastnameError("Last Name is required!");
        } else if(e.target.value.length < 2) {
            setLastnameError("Last Name must be 2 characters or longer!");
        } else {
            setLastnameError("");
        }
    }

    const handleEmail = (e) => {
        setEmail(e.target.value);
        if(e.target.value.length < 1) {
            setEmailError("Email is required!");
        } else if(e.target.value.length < 5) {
            setEmailError("Email must be 5 characters or longer!");
        } else {
            setEmailError("");
        }
    }

    const handlePassword = (e) => {
        setPassword(e.target.value);
        if(e.target.value.length < 1) {
            setPasswordError("Password is required!");
        } else if(e.target.value.length < 8) {
            setPasswordError("Password must be 8 characters or longer!");
        } else {
            setPasswordError("");
        }
    }

    const handleConfirmpasswordError = (e) => {
        setConfirmpassword(e.target.value);
        if(e.target.value.length < 1) {
            setConfirmpasswordError("Confirm Password is required!");
        } else if(e.target.value.length < 8) {
            setConfirmpasswordError("Password must be 8 characters or longer!");
        } else {
            setConfirmpasswordError("");
        }
        if (e.target.value !== password) {
            setMatchError("Passwords must match!");
        } else {
            setMatchError("");
        }
    }

    return(
        <>
        <form onSubmit={ createUser }>
            <h3>{ formMessage() }</h3>
            <div>
                <label>First Name: </label> 
                <input type="text" onChange={ handleFirstname } />
                {
                    firstnameError ?
                    <p style={{color:'red'}}>{ firstnameError }</p> :
                    ''
                }
            </div>
            <div>
                <label>Last Name: </label> 
                <input type="text" onChange={ handleLastname } />
                {
                    lastnameError ?
                    <p style={{color:'red'}}>{ lastnameError }</p> :
                    ''
                }
            </div>
            <div>
                <label>Email Address: </label> 
                <input type="text" onChange={ handleEmail } />
                {
                    emailError ?
                    <p style={{color:'red'}}>{ emailError }</p> :
                    ''
                }
            </div>
            <div>
                <label>Password: </label>
                <input type="text" onChange={ handlePassword } />
                {
                    passwordError ?
                    <p style={{color:'red'}}>{ passwordError }</p> :
                    ''
                }
                {
                    matchError ?
                    <p style={{color:'red'}}>{ matchError }</p> :
                    ''
                }
            </div>
            <div>
                <label>Confirm Password: </label>
                <input type="text" onChange={ handleConfirmpasswordError } />
                {
                    confirmpasswordError ?
                    <p style={{color:'red'}}>{ confirmpasswordError }</p> :
                    ''
                }
            </div>
            <input type="submit" value="Create User" />
        </form>
        <div>
            <p className="text-center">Your Form Data</p>
            <table class="table mx-auto">
                <thead>
                    <tr>
                        <td>First Name</td>
                        <td>{ firstname }</td>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Last Name</td>
                        <td>{ lastname }</td>
                    </tr>
                    <tr>
                        <td>Email</td>
                        <td>{ email }</td>
                    </tr>
                    <tr>
                        <td>Password</td>
                        <td>{ password }</td>
                    </tr>
                    <tr>
                        <td>Confirm<br />Password</td>
                        <td>{ confirmpassword }</td>
                    </tr>
                </tbody>
            </table>
            <p>Bottom Text</p>
        </div>
        </>
    );
}

export default Form;