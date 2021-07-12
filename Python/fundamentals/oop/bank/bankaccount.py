class BankAccount:
    # class attribute
    bank_name = "First National Dojo"
    all_accounts = []
    def __init__(self, int_rate, balance):
        self.int_rate = int_rate
        self.balance = balance
        BankAccount.all_accounts.append(self)
    # class method to change the name of the bank
    @classmethod
    def change_bank_name(cls,name):
        cls.bank_name = name
    # class method to get balance of all accounts
    @classmethod
    def all_balances(cls):
        sum = 0
        # we use cls to refer to the class
        for account in cls.all_accounts:
            sum += account.balance
        return sum

    def deposit(self, amount):
        self.balance += amount
        return self
    def withdraw(self,amount):
        # we can use the static method here to evaluate
        # if we can with draw the funds without going negative
        if BankAccount.can_withdraw(self.balance,amount):
            self.balance -= amount
        else:
            print("Insufficient funds: Charging a $5 fee")
            self.balance -= 5
        return self
    def display_account_info(self):
        print(f"Balance: ${self.balance}")
        return self
    def yield_interest(self):
        if self.balance > 0:
            self.balance *= (1+self.int_rate)
        return self
    def printAccInfo(self):
        print(f"Current Balance: {self.balance}, Current Interest Rate: {self.int_rate}")
    # static methods have no access to any attribute
    # only to what is passed into it
    @staticmethod
    def can_withdraw(balance,amount):
        if (balance - amount) < 0:
            return False
        else:
            return True
acc1=BankAccount(0.01,1000)
acc2=BankAccount(0.021,9000)
acc1.deposit(100).deposit(100).deposit(100).withdraw(50).yield_interest().display_account_info()
acc2.deposit(100).deposit(100).withdraw(1500).withdraw(1500).withdraw(1500).withdraw(1500).yield_interest().display_account_info()
acc2.printAccInfo()