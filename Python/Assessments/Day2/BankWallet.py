
def createWallet(balance,username):

    def Deposit():
        nonlocal balance
        amount=int(input("Enter the amount: "))
        balance+=amount
        print("Deposit made: ", amount)
        print("Updated Balance: ", balance)
       

    
    def Withdraw():
        nonlocal balance
        amount=int(input("Enter the amount: "))
        if(balance>=amount):
            balance-=amount
            print("Withdrawal made: ", amount)
            print("Updated Balance: ", balance)
        else:
            print("Available balance is low")
        
        
    def ShowBalance():
        nonlocal balance
        print("the available balance for "+username+" is ",balance)
        
    def Transfer(username):
        nonlocal balance
        amount=int(input("Enter the amount: "))
        print(type(amount))
        if(balance>=amount):
            balance=balance-amount
           
            print("'Hello!, Transfer from "+ username +" of Rs. "+ str(amount) +" is done successfully")
            print("Updated Balance is ",balance)
        else:
            print("Available balance is low")
       

    list=[Deposit,Withdraw,ShowBalance,Transfer]
    return list

 
username=input("Enter the username: ")
print(type(username))
pin=int(input("Enter the pin: "))   
balance=int(input("Enter Initial Balance: "))
a=createWallet(balance,username) 
b=createWallet(balance,username)


#b=createWallet(balance,username,pin)  

if(pin==1234):
    
   
    print("Choose the desired option.\n 1.Deposit\n 2.Withdraw\n 3.ShowBalance\n 4.Transfer\n")
    choice=int(input("Enter the Choice: "))
    
    if(choice==1):
        a[choice-1]()
    elif(choice==2):
        a[choice-1]()
    elif(choice==3):
        a[choice-1]()
    elif(choice==4):
        a[choice-1](username)
elif(pin==2345):
    print("Choose the desired option.\n 1.Deposit\n 2.Withdraw\n 3.ShowBalance\n 4.Transfer\n")
    choice=int(input("Enter the Choice: "))
    
    if(choice==1):
        b[choice-1]()
    elif(choice==2):
        b[choice-1]()
    elif(choice==3):
        b[choice-1]()
    elif(choice==4):
        b[choice-1](username)
else:
    print("Invalid Password")
    

 
  
 


