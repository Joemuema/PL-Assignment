while True:
    weight = float(input("\nEnter your current body weight(kg): "))
    height = float(input("Enter your current height(m): "))

    BMI = weight / (height * height)
    if BMI < 18.5 :
        if BMI > 17.5 :
            print("You are slightly underweight.")
        elif BMI > 14.0:
            print("You are underweight.")
        else :
            print("You are severely underweight.")
    
    elif BMI < 25.0 :
        print("You are at a normal weight.")
    
    else :
        if BMI < 26.0 :
            print("You are slightly overweight.")
        elif BMI < 30.0 :
            print("You are overweight.")
        else :
            print("You are severely overweight.")

    option = ""
    while True:
        option = input("\nExit BMI calculator?(Y/N) ")
        if option in ["Y" , "y" , "N" , "n"] :
            break
        else :
            print("Invalid option. Enter Y to exit or N to continue.")
    
    if option in ["Y" , "y"] :
        break