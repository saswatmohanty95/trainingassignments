x= int(input("Enter number for factorial calculation: "))

fact = 1
# check if the number is negative, positive or zero
if x < 0:
   print("Please enter a number > 0")
elif x == 0:
   print("Factorial of 0 is 1")
else:
   for i in range(1,x + 1):
       fact = fact*i
   print("Factorial of",x,"is:",fact)