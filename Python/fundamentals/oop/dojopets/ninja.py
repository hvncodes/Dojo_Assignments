from pet import Pet
class Ninja:
    # implement __init__( first_name , last_name , treats , pet_food , pet )
    def __init__(self, first_name, last_name, treats="Greenies", pet_food="Iams"):
        self.first_name = first_name
        self.last_name = last_name
        self.treats = treats
        self.pet_food = pet_food
        self.pet = ""
    def addPet(self, pet_name="Dino", pet_type="Dog", pet_tricks="Sit", sound="Woof"):
        self.pet = Pet(pet_name, pet_type, pet_tricks, sound)
        return self
    def displayInfo(self):
        print(f"{self.first_name} {self.last_name} has a pet {self.pet.type} that can do a {self.pet.tricks}.")
        print(f"The pet currently has {self.pet.energy} Energy and {self.pet.health} Health")
        return self
    # implement the following methods:
    # walk() - walks the ninja's pet invoking the pet play() method
    # feed() - feeds the ninja's pet invoking the pet eat() method
    # bathe() - cleans the ninja's pet invoking the pet noise() method
    def walk(self):
        self.pet.play()
        return self
    def feed(self):
        self.pet.eat()
        return self
    def bathe(self):
        self.pet.noise()
        return self
george = Ninja("George","Of The Jungle")
george.addPet("Sandy", "Shark", "Surf", "SHAAAAAARK")
george.feed().walk().displayInfo().bathe()