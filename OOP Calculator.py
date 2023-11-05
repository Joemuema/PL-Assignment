class Calculator:
    def __init__(self, name):
        self.name = name

    def add(self, num1, num2):
        print("Sum = ", num1 + num2)

    def subtract(self, num1, num2):
        print("Difference = ", num1 - num2)

    def multiply(self, num1, num2):
        print("Product = ", num1 * num2)

    def divide(self, num1, num2):
        if num2 != 0:
            print("Quotient = ", num1 / num2)
        else:
            print("Cannot divide by zero")


name = input("Hello there, May I ask your name? ")
print("Hello, ", name ,".\n Welcome to the Object-Oriented Calculator.")
myCalc = Calculator(name)

while True:
    print("\nOperations: add, subtract, multiply, divide")    
    user_input = input("Enter your desired operation: ")

    if user_input in ["add" , "+" , "subtract" , "-" , "multiply" , "*" , "divide" , "/"]:
        num1 = float(input("Enter first number: "))
        num2 = float(input("Enter second number: "))

        print("Result: ", end = "")
        if user_input in ["add" , "+"]:
            myCalc.add(num1, num2)
        elif user_input in ["subtract" , "-"]:
            myCalc.subtract(num1, num2)
        elif user_input in ["multiply" , "*"]:
            myCalc.multiply(num1, num2)
        elif user_input in ["divide" , "/"]:
            myCalc.divide(num1, num2)
    else:
        print("Invalid input")
        continue

    option = ""
    while True:
        option = input("\nExit OOP calculator?(Y/N) ")
        if option in ["Y" , "y" , "N" , "n"] :
            break
        else :
            print("Invalid option. Enter Y to exit or N to continue.")
    
    if option in ["Y" , "y"] :
        print("\nGoodbye ", myCalc.name ,". Hope you come back!")
        break