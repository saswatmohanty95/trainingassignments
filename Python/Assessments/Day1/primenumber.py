num= input("Enter number: ")
n= int(num)
i=1
j=0
while (i<=n):
    if (n%i==0):
        print(i)
        j+=1
    
    i+=1

if(j==2):
    print("Prime")
else:
    print("Not prime")

