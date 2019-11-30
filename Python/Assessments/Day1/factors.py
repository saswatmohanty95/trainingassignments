num= input("Enter number: ")
n=int(num)
i=1;
sum=0;
while (i<=n):
    if (n%i==0):
        
        
        print(i)
        
        sum=sum+i
    i+=1
print("The sum is: ",sum)