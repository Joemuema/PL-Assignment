"""
Name: Joseph Muema
Reg Number: SCT211-0039/2022
Course: Bsc Computer Science
"""

def add(x,y):
    return x+y

def subtract(x,y):
    return x-y

def multiply(x,y):
    return x*y

def divide(x,y):
    if y==0:
        return "Cannot divide by zero"
    return x/y

name=input("Hello there, May I ask your name? ")
print("Hello, ",name)
print("Welcome to The Simple Calculator.")

while True:
    print("\nOperations: add,subtract,multiply,divide,quit")    
    user_input=input("Enter the name of your desired operation/command: ")

    if user_input=="quit":
        print("Turning off...\nGoodBye.")
        break
    elif user_input in ["add","subtract","multiply","divide"]:
        num1=input("Enter first number: ")
        num2=input("Enter second number: ")

        print("Result: ",end="")
        if user_input=="add":
            print(add(num1,num2))
        elif user_input=="subtract":
            print(subtract(num1,num2))
        elif user_input=="multiply":
            print(multiply(num1,num2))
        elif user_input=="divide":
            print(divide(float(num1),float(num2)))
    else:
        print("Invalid input")

