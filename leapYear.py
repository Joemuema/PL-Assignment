while True :
    year = int(input("\nEnter the year to check: "))
    leap = False

    if(year % 4 == 0) :
        if year % 100 != 0 or (year % 100 == 0 and year % 400 == 0) :
            print(year , " is a leap year.")
            leap = True

    if leap == False :
        print(year , " is NOT a leap year.")

    option = ""
    while True:
        option = input("\nExit?(Y/N) ")
        if option in ["Y" , "y" , "N" , "n"] :
            break
        else :
            print("Invalid option. Enter Y to exit or N to continue.")
    
    if option in ["Y" , "y"] :
        break