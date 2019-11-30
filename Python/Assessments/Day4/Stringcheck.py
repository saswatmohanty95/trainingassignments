def demo(a):
    def inner(*args,**kwargs):
        for i in args:
            if type(i) != str:
                print("Invalid")
                break
        else:
            for i in kwargs.values():
                if type(i) != str:
                    print("Invalid")
                    break
            else:
                a(*args, **kwargs)
        print("Inner finished execution")
    return inner
 
@demo  #(shortcut instead of line 31)
def sayhi(name):
    print("Hi All"+ name)

@demo    
def sayhello(name1,name2):
    print("Hello World"+name1+name2)
	
sayhi("Sachin")
sayhello("Sahil",name2="Samar")
sayhello(name1="Sahil",name2="Samar")
