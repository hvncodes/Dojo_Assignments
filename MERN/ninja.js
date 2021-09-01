// parent Ninja class
class Ninja {
    constructor(name, health) {
        this.name = name;
        this.health = health;
        this.speed = 3;
        this.strength = 3;
    }
    // log that Ninja's name to the console
    sayName() {
        console.log(`My name is ${ this.name } and I am a ${ this.constructor.name }.`);
    }
    // show the Ninja's name, strength, speed, and health.
    showStats() {
        console.log(`${ this.name } stats:`);
        console.log(` ${ this.strength } strength`);
        console.log(` ${ this.speed } speed`);
        console.log(` ${ this.health } health`);
    }
    // add +10 Health to the Ninja
    drinkSake() {
        this.health += 10;
        console.log(`${ this.name } drank some sake and recovered 10 health.\n Health: ${ this.health }`);
    }
}

const ninja1 = new Ninja("Hyabusa", 10);
ninja1.sayName();
ninja1.showStats();
ninja1.drinkSake();