# Countdown - Create a function that accepts a number as an input.
# Return a new list that counts down by one, from the number
# (as the 0th element) down to 0 (as the last element).
def countdown(num):
    countdownList = [];
    for x in range(num, -1, -1):
        countdownList.append(x)
    return countdownList
print(countdown(5))

# Print and Return - Create a function that will receive a list
# with two numbers. Print the first value and return the second.
# Example: print_and_return([1,2]) should print 1 and return 2
def printReturn(list):
    print(list[0])
    return list[1]
print(printReturn([1,2]))

# First Plus Length - Create a function that accepts a list and
# returns the sum of the first value in the list plus the list's length.
# Example: first_plus_length([1,2,3,4,5]) should return 6 (first value: 1 + length: 5)
def firstPlusLength(list):
    first = list[0]
    last = list[len(list)-1]
    return first+last
print(firstPlusLength([1,2,3,4,5]))

# Values Greater than Second - Write a function that accepts a list 
# and creates a new list containing only the values from the original
# list that are greater than its 2nd value. Print how many values this
# is and then return the new list. If the list has less than 2 elements,
# have the function return False
# Example: values_greater_than_second([5,2,3,2,1,4]) should print 3 and return [5,3,4]
# Example: values_greater_than_second([3]) should return False
def valuesGreaterThanSecond(list):
    if len(list) < 2:
        return False
    second = list[1]
    returnList = []
    counter = 0
    for x in range(len(list)):
        if list[x] > second:
            counter = counter + 1
            returnList.append(list[x])
    print(counter)
    return returnList
valuesGreaterThanSecond([5,2,3,2,1,4])
valuesGreaterThanSecond([3])

# This Length, That Value - Write a function that accepts two integers
# as parameters: size and value. The function should create and return
# a list whose length is equal to the given size, and whose values are
# all the given value.
def lengthAndValue(int1, int2):
    returnList = []
    for i in range(int1):
        returnList.append(int2)
    print(returnList)
    return returnList
lengthAndValue(4,7)
lengthAndValue(6,2)