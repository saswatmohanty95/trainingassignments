a=input("Enter Year:")

if int(a)%400==0:
	print("leap year")
elif int(a)%100==0:
	print("Not a leap year")
elif int(a)%4==0:
	print("Leap Year")
