while True:
    totalBill = float(input("Enter the bill information below\nTotal Bill: "))
    tipPercentage = int(input("Tip percentage:(10%,12%,15%) "))
    people = int(input("Total number of people splitting the bill: "))
    
    personalBill = totalBill / people
    output = "{:.2f}".format(personalBill * (1 + tipPercentage / 100))
    print("Each person should pay ", output)

    option = ""
    while True:
        option = input("\nExit tip calculator?(Y/N) ")
        if option in ["Y" , "y" , "N" , "n"] :
            break
        else :
            print("Invalid option. Enter Y to exit or N to continue.")
    
    if option in ["Y" , "y"] :
        break