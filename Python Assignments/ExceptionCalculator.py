import datetime

def add(x , y):
    return x + y

def subtract(x , y):
    if y > x:
        raise ValueError("Negative value returned.")
    return x - y

def multiply(x , y):
    return x * y

def divide(x , y):
    if y == 0: 
        raise ValueError("Cannot divide by zero.")
    return x / y

def arithmeticCalc():
    while True:
        print("\nOperations: add,subtract,multiply,divide")    
        user_input = input("Enter your desired operation: ")
        result = 0
        errorFound = False

        if user_input in ["add" , "+" , "subtract" , "-" , "multiply" , "*" , "divide" , "/"]:
            num1 = float(input("Enter first number: "))
            num2 = float(input("Enter second number: "))

            if user_input in ["add" , "+"]:

                result = add(num1, num2)

            elif user_input in ["subtract" , "-"]:

                try:
                    result = subtract(num1, num2)
                except Exception as e:
                    print(f"An error occurred: {e}")
                    errorFound = True
                
            elif user_input in ["multiply" , "*"]:

                result = multiply(num1, num2)

            elif user_input in ["divide" , "/"]:

                try:
                    result = divide(num1, num2)
                except Exception as e:
                    print(f"An error occurred: {e}")
                    errorFound = True
                
            if errorFound == False:
                print("Result: ", result)
        
        else:
            print("Invalid input")
            continue

        option = ""
        while True:
            option = input("\nExit arithmetic calculator?(Y/N) ")
            if option in ["Y" , "y" , "N" , "n"] :
                break
            else :
                print("Invalid option. Enter Y to exit or N to continue.")
        
        if option in ["Y" , "y"] :
            break

def ageCalc():
    while True:
        print("\nEnter your date of birth below:")
        birthDay = int(input("Day: "))
        birthMonth = int(input("Month: "))
        birthYear = int(input("Year: "))

        today = datetime.date.today()
        currentDay = today.day
        currentMonth = today.month
        currentYear = today.year

        totalDays = (currentYear - birthYear) * 365 + (currentMonth - birthMonth) * 30 + (currentDay - birthDay)
        print("You are approximately ", int(totalDays / 365) ,"years, ", int((totalDays % 365) / 30) ," months and ", int(totalDays % 365 % 30) ," days old")
        
        option = ""
        while True:
            option = input("\nExit age calculator?(Y/N) ")
            if option in ["Y" , "y" , "N" , "n"] :
                break
            else :
                print("Invalid option. Enter Y to exit or N to continue.")
        
        if option in ["Y" , "y"] :
            break


name=input("Hello there, May I ask your name? ")
print("Hi, ", name ,".")
print("Welcome to The Modified Calculator.\nIt can do both arithmetic and age calculations.")

while True:
    print("\nChoose calculator type: \n1. Arithmetic calculator\n2. Age calculator")
    choice = int(input("Option: "))

    if choice == 1:
        arithmeticCalc()
    elif choice == 2:
        ageCalc()
    else:
        print("Invalid choice. Enter 1 for arithmetic calculator, 2 for age calculator.")
        continue

    option = ""
    while True:
        option = input("\nTurn off modified calculator?(Y/N) ")
        if option in ["Y" , "y" , "N" , "n"] :
            break
        else :
            print("Invalid option. Enter Y to exit or N to continue.")
    
    if option in ["Y" , "y"] :
        print("\nGoodbye ", name ,". Hope you come back!")
        break
