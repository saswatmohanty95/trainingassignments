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
    
 

style='''Name={name}
Category={category}
Brand={brand}
Cost={cost}
Rating={rating}
Discount={discount}\n\n'''


print(" 1.Cost low-high\n 2.Cost high-low\n 3.Rating\n 4.Discount low-high\n 5.Discount high-low")
choice=int(input("ENTER YOUR CHOICE: "))

print("\n")

sortfil=[
["cost",False],
["cost",True],
["rating",True],
["discount",False],
["discount",True]
]

products.sort(key=(lambda elm:elm[sortfil[choice-1][0]]),reverse=sortfil[choice-1][1])


for i in products:
    print(style.format(**i))


  
print("Select appropriate filter: 1.By Category\n 2.By Brand\n 3.By Name")
choice=int(input("ENTER YOUR CHOICE: "))  


prodfilter=["category","brand","name"]

entry=input("Enter: ")
newobj=filter(lambda eln:eln[prodfilter[choice-1]]==entry,products)


for i in newobj:
     print(style.format(**i))







