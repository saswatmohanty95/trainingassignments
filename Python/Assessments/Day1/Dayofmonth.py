'''
a=input("Enter date in number dd:")
if int(a)%7==1:
	print("Friday")
elif int(a)%7==2:
	print("Saturday")
elif int(a)%7==3:
	print("Sunday")
elif int(a)%7==4:
	print("Monday")
elif int(a)%7==5:
	print("Tuesday")
elif int(a)%7==6:
	print("Wednesday")
elif int(a)%7==0:
	print("Thursday")
'''


days=['Thursday','Friday','Saturday','Sunday','Monday','Tuesday','Wednesday']
date=input("Enter date in dd format for the month of November: ")
d=int(date)
if d>0 and d<=30:

	print(days[(d%7)])

else:
	print("Invalid Date")


