num1 = 42 #variable declaration, Numbers
num2 = 2.3
boolean = True #variable declaration, Boolean
string = 'Hello World' #variable declaration, Strings
pizza_toppings = ['Pepperoni', 'Sausage', 'Jalepenos', 'Cheese', 'Olives'] #variable declaration, initialize, List
person = {'name': 'John', 'location': 'Salt Lake', 'age': 37, 'is_balding': False} #variable declaration, initialize, Dictionary
fruit = ('blueberry', 'strawberry', 'banana') #variable declaration, initialize, Tuples
print(type(fruit)) #log statement, type check
print(pizza_toppings[1]) #log statement, List, access value
pizza_toppings.append('Mushrooms') #List, add value
print(person['name']) #log statement, Dictionary, access value
person['name'] = 'George' #Dictionary, change value
person['eye_color'] = 'blue' #Dictionary, add value
print(fruit[2]) #log statement, Tuples, access value

if num1 > 45: #if
    print("It's greater") #log statement
else: #else
    print("It's lower") #log statement

if len(string) < 5: #if
    print("It's a short word!") #log statement
elif len(string) > 15: #else if
    print("It's a long word!") #log statement
else: #else
    print("Just right!") #log statement

for x in range(5):
    print(x) #log statement
for x in range(2,5):
    print(x) #log statement
for x in range(2,10,3):
    print(x) #log statement
x = 0
while(x < 5): #start
    print(x) #log statement
    x += 1 #increment
#stop
pizza_toppings.pop() #List, delete value
pizza_toppings.pop(1) #List, access value, delete value

print(person) #log statement
person.pop('eye_color') #Dictionary, access value, delete value
print(person) #log statement

for topping in pizza_toppings: #sequence
    if topping == 'Pepperoni': #if
        continue #continue
    print('After 1st if statement') #log statement
    if topping == 'Olives': #if
        break #break

def print_hello_ten_times(): #function
    for num in range(10): #sequence
        print('Hello') #log statement

print_hello_ten_times()

def print_hello_x_times(x): #function, parameter
    for num in range(x): #sequence, argument
        print('Hello') #log statement

print_hello_x_times(4)

def print_hello_x_or_ten_times(x = 10): #function, argument
    for num in range(x): #sequence, argument
        print('Hello') #log statement

print_hello_x_or_ten_times() #function
print_hello_x_or_ten_times(4) #function, argument


"""
Bonus section
"""

# print(num3)
# num3 = 72
# fruit[0] = 'cranberry'
# print(person['favorite_team'])
# print(pizza_toppings[7])
#   print(boolean)
# fruit.append('raspberry')
# fruit.pop(1)