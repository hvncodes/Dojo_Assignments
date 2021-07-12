from bankaccount import BankAccount
# declare a class and give it name User
class User:
    # class attributes get defined in the class
    # declaring a class attribute
    bank_name = "First National Dojo"
    # now our method has 2 parameters!
    # instance attributes
    def __init__(self, name, email_address):
        # we assign them accordingly
        self.name = name
        self.email = email_address
        # the account balance is set to $0
        #self.account_balance = 0
        self.account = BankAccount(int_rate=0.02, balance=0)
    # takes an argument that is the amount of the deposit
    def make_deposit(self, amount):
        # the specific user's account increases by the amount of the value received
        self.account.deposit(amount)
        return self
    def make_withdrawal(self, amount):
        self.account.withdraw(amount)
        return self
    # print the user's name and account balance to the terminal
    # User: Guido van Rossum, Balance: $150
    def display_user_balance(self):
        print(f"User: {self.name}, Balance: ${self.account.balance}")
        return self
    # decrease the user's balance by the amount and add that amount to other other_user's balance
    def transfer_money(self, other_user, amount):
        self.account.withdraw(amount)
        other_user.account.deposit(amount)
        return self
guido = User("Guido van Rossum", "guido@python.com")
monty = User("Monty Python", "monty@python.com")
john = User("John N", "john@python.com")
fourth = User("Momento Mori", "4444@python.com")
guido.make_deposit(50)
guido.make_deposit(100)
guido.make_deposit(200)
guido.make_withdrawal(50)
guido.display_user_balance()    # User: Guido van Rossum, Balance: $300
monty.make_deposit(50)
monty.make_deposit(300)
monty.make_withdrawal(150)
monty.make_withdrawal(150)
monty.display_user_balance()    # User: Monty Python, Balance: $50
john.make_deposit(500)
john.make_withdrawal(100)
john.make_withdrawal(200)
john.make_withdrawal(150)
john.display_user_balance()     # User: John N, Balance: $50
guido.transfer_money(john,50)
guido.display_user_balance()    # User: Guido van Rossum, Balance: $250
john.display_user_balance()     # User: John N, Balance: $100
# User: Momento Mori, Balance: $550
# User: Momento Mori, Balance: $650
fourth.make_deposit(100).make_deposit(200).make_deposit(300).make_withdrawal(50).display_user_balance().make_deposit(100).display_user_balance()
