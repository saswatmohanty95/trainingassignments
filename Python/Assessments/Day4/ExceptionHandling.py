class NameNotFound(Exception):
    def __init__(self,msg="name not found"):
        Exception.__init__(self,msg)
        
class PasswordInvalid(Exception):
    def __init__(self,msg="Invalid Password. Please try again"):
        Exception.__init__(self,msg)
        
try:
    names={"Sachin":"ICC","Saurav":"BCCI","Virat":"Ravi"}
    username=input("Enter Name: ")
    password=input("Enter Password: ")
    
    if username not in names:
        raise NameNotFound
    else:
        if password not in names.get(username):
            raise PasswordInvalid
        else:
           
            print("Login Success. Welcome "+ username)

except NameNotFound as e:
    print(e)
except PasswordInvalid as e:
    print(e)     