fo = open('desert.jpg', 'rb')
i = 0
for line in fo:
    fo1 = open('chunks/demo' + str(i) + '.jpg', 'wb')
    print(line)
    i += 1
    fo1.write(line)
    fo1.close()
fo.close()