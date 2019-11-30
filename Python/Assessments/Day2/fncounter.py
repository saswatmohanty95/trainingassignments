def outer():
    count=0
    def inner():
        nonlocal count
        count+=1
        print("Count: ", count)  
    return inner

hello = outer()
hello()
hello()
hello()