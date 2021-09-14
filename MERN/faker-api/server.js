const express = require("express");
const faker = require("faker");
const app = express();
const port = 8000;
app.use( express.json() );
app.use( express.urlencoded({ extended: true }) );

class User {
    constructor() {
        this._id = faker.datatype.uuid()
        this.firstName = faker.name.firstName();
        this.lastName = faker.name.lastName();
        this.phoneNumber = faker.phone.phoneNumber();
        this.email = faker.internet.email();
        this.password = faker.internet.password()
    }
}
// console.log(new User());

class Company {
    constructor() {
        this._id = faker.datatype.uuid()
        this.name = faker.company.companyName();
        this.address = {
            street : faker.address.streetAddress(),
            city : faker.address.cityName(),
            state : faker.address.state(),
            zipCode : faker.address.zipCodeByState(),
            country : faker.address.country(),
        }
        
    }
}
// console.log(new Company());

app.get("/api", (req, res) => {
    res.json({ message: "Hello World" });
});

app.get("/api/users/new", (req, res) => {
    res.json( new User() );
});

app.get("/api/companies/new", (req, res) => {
    res.json( new Company() );
});

app.get("/api/user/company", (req, res) => {
    res.json( [new User(), new Company()] );
});

app.listen( port, () => console.log(`Listening on port: ${port}`) );