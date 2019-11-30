with open("desert.jpg","rb+") as fo:
    with open("newdesert.jpg","wb+") as copyfo:
        for i in fo:
            copyfo.write(i)