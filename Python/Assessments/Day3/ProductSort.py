products=[
    {
    "pid":"1",
    "name":"Laptop",
    "cost":"45000",
    "brand":"Dell",
    "category":"Electronics",
    "rating":"4.5",
    "discount":10
    },
      {
    "pid":"2",
    "name":"Laptop",
    "cost":"51000",
    "brand":"HP",
    "category":"Electronics",
    "rating":"4.2",
    "discount":15
    },
      {
    "pid":"3",
    "name":"SmartPhone",
    "cost":"21999",
    "brand":"Redmi",
    "category":"Electronics",
    "rating":"4.8",
    "discount":5
    },
      {
    "pid":"4",
    "name":"Reno 2",
    "cost":"23999",
    "brand":"Oppo",
    "category":"Electronics",
    "rating":"4.6",
    "discount":7.5
    },
      {
    "pid":"5",
    "name":"Shoes",
    "cost":"2999",
    "brand":"Bata",
    "category":"Footwear",
    "rating":"3.7",
    "discount":10
    },
      {
    "pid":"6",
    "name":"Slippers",
    "cost":"699",
    "brand":"Paragon",
    "category":"Footwear",
    "rating":"4",
    "discount":None
    },
       {
    "pid":"7",
    "name":"Jeans",
    "cost":"1899",
    "brand":"Levi's",
    "category":"Clothing",
    "rating":"3.9",
    "discount":5
    },
       {
    "pid":"8",
    "name":"Tshirt",
    "cost":"899",
    "brand":"Allen Solly",
    "category":"Clothing",
    "rating":"3.5",
    "discount":10
    },
       {
    "pid":"9",
    "name":"Analog Watch",
    "cost":"23600",
    "brand":"Rado",
    "category":"Watches",
    "rating":"4.8",
    "discount":None
    },
       {
    "pid":"10",
    "name":"Smart Watch",
    "cost":"2399",
    "brand":"MI",
    "category":"Watches",
    "rating":"4.4",
    "discount":8
    },
    ]


class Products:
    def __init__(obj,pid,name,cost,brand,category,rating,discount):
        obj.pid=pid
        obj.name=name
        obj.cost=cost
        obj.brand=brand
        obj.category=category
        obj.rating=rating
        obj.discount=discount
    
    
    def todisplay(obj):
        print(obj.pid, " ", obj.name, " ", obj.brand, " ", obj.cost, " ", obj.category, " ", obj.rating, " ",obj.discount)



prodlist=[]        
        
for i in products:
    prodlist.append(Products(**i))

sortfil = {1: ["cost", False], 2: ["cost", True], 3: ["rating", True], 4: ["discount", True], 5: ["discount", False]}
choice = -1
while choice != 0:
    print("1.Sort by cost Low to High")
    print("2.Sort by cost High to Low")
    print("3.Sort by Rating")
    print("4.Sort by Discount High to Low")
    print("5.Sort by Discount Low to High")
    print("0.Exit")
    choice = int(input("Select your choice of operation: "))
    if choice != 0:
        prodlist.sort(key=lambda ele: ele.__getattribute__(sortfil[choice][0]), reverse=(sortfil[choice][1]))
        for i in prodlist:
            i.todisplay()

    
    
    
    


 