x = [ [5,2,3], [10,8,9] ] 
students = [
    {'first_name':  'Michael', 'last_name' : 'Jordan'},
    {'first_name' : 'John', 'last_name' : 'Rosales'}
]
sports_directory = {
    'basketball' : ['Kobe', 'Jordan', 'James', 'Curry'],
    'soccer' : ['Messi', 'Ronaldo', 'Rooney']
}
z = [ {'x': 10, 'y': 20} ]

# Change the value 10 in x to 15.
# Once you're done, x should now be [ [5,2,3], [15,8,9] ].
x[1][0] = 15
print(x)
# Change the last_name of the first student from 'Jordan' to 'Bryant'
students[0]["last_name"] = "Bryant"
print(students)
# In the sports_directory, change 'Messi' to 'Andres'
sports_directory["soccer"][0] = "Andres"
print(sports_directory)
# Change the value 20 in z to 30
z[0]["y"] = 30
print(z)

students = [
    {'first_name':  'Michael', 'last_name' : 'Jordan'},
    {'first_name' : 'John', 'last_name' : 'Rosales'},
    {'first_name' : 'Mark', 'last_name' : 'Guillen'},
    {'first_name' : 'KB', 'last_name' : 'Tonel'}
]
# should output: (it's okay if each key-value pair ends up on 2 separate lines;
# bonus to get them to appear exactly as below!)
# first_name - Michael, last_name - Jordan
# first_name - John, last_name - Rosales
# first_name - Mark, last_name - Guillen
# first_name - KB, last_name - Tonel
def iterateDictionary(list):
    for x in range(len(list)):
        returnStr = "";
        # list[x] {'first_name': 'Michael', 'last_name': 'Jordan'}
        # list[x].keys() ['first_name', 'last_name']
        # y 'first_name' ... etc
        for y in list[x]:
            returnStr = returnStr + y + " - " + list[x].get(y)
            if (y != "last_name"):
                returnStr = returnStr + ", "
        print(returnStr)
        # simple solution from class
        # for item in list:
        #     print(f"first_name - {item['first_name']}, last_name - {item['last_name']}")
iterateDictionary(students) 

def iterateDictionary2(key_name, some_list):
    for x in range(len(some_list)):
        print(some_list[x].get(key_name))
    # same way
    # for item in some_list:
    #     print(item[key_name])
# # Michael
# # John
# # Mark
# # KB
iterateDictionary2('first_name', students)
# # Jordan
# # Rosales
# # Guillen
# # Tonel
iterateDictionary2('last_name', students)

dojo = {
   'locations': ['San Jose', 'Seattle', 'Dallas', 'Chicago', 'Tulsa', 'DC', 'Burbank'],
   'instructors': ['Michael', 'Amy', 'Eduardo', 'Josh', 'Graham', 'Patrick', 'Minh', 'Devon']
}
# output:
# 7 LOCATIONS
# San Jose
# Seattle
# Dallas
# Chicago
# Tulsa
# DC
# Burbank
    
# 8 INSTRUCTORS
# Michael
# Amy
# Eduardo
# Josh
# Graham
# Patrick
# Minh
# Devon
def printInfo(dict):
    for x in dict:
        #x: locations, instructors
        # dict[x]: ['San Jose', 'Seattle', 'Dallas', 'Chicago', 'Tulsa', 'DC', 'Burbank'] ...
        print(str(len(dict[x])),x.upper())
        for y in dict[x]:
            print(y)
        print("")
printInfo(dojo)