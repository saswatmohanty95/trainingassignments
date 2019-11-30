fo=open('newimageafterdechunking.jpg','wb')
for i in range(0,308):
    fo1 = open('chunks/demo' + str(i) + '.jpg', 'rb')
    for line in fo1:
        fo.write(line)
    fo1.close()
fo.close()