class Card {
    constructor(name, cost) {
        this.name = name;
        this.cost = cost;
    }
}

class Unit extends Card {
    constructor(name, cost, power, res) {
        super(name, cost);
        this.power = power;
        this.res = res;
    }

    attack(target) {
        console.log(`${ this.name } (Power: ${ this.power }) attacked ${ target.name } (Resilience: ${ target.res })`);
        console.log(`${ target.name } lost ${ this.power } Resilience`);
        // reduce target res by power
        target.res -= this.power;
        console.log(`${ target.name } has ${ target.res } Resilience left`);
        console.log("----------------------");
    }
}

class Effect extends Card {
    constructor(name, cost, text, stat, mag) {
        super(name, cost);
        this.text = text;
        this.stat = stat;   // target of effect (power/res)
        this.mag = mag;     // by how much
    }

    play(target) {
        if( target instanceof Unit ) {
            // implement card text here
            console.log(`${ this.name } is played on ${ target.name }\nEffect: ${ this.text }`);
            if (this.stat == "power") { // targetting target's power
                let oldPower = target.power;
                target.power += this.mag;
                console.log(`${ target.name }'s Power is now ${ target.power } (from ${ oldPower })`);
            } else {                    // targetting target's resilience
                let oldResilience = target.res;
                target.res += this.mag;
                console.log(`${ target.name }'s Resilience is now ${ target.res } (from ${ oldResilience })`);
            }
        } else {
            throw new Error( "Target must be a unit!" );
        }
        console.log("----------------------");
    }
}
let redbeltninja    = new Unit("Red Belt Ninja", 3, 3, 4);
let blackbeltninja  = new Unit("Black Belt Ninja", 4, 4, 4);
let hardalg = new Effect("Hard Algorithm", 2, "increase target's resilience by 3", "resilience", 3);
let promrej = new Effect("Unhandled Promise Rejection", 1, "reduce target's resilience by 2", "resilience", -2);
let pairpro = new Effect("Pair Programming", 3, "increase target's power by 2", "power", 2);

hardalg.play(redbeltninja);
promrej.play(redbeltninja);
pairpro.play(redbeltninja);
redbeltninja.attack(blackbeltninja);