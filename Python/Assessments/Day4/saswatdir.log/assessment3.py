import os
import re
dir = "C:\\Users\\smohanty69\\Documents\\Practice\\Assessments\Day4\\saswatdir.log"
for root, dirs, files in os.walk(dir):
    for file in files:
        if file.endswith('.log'):
            fo=open(file,"r")
            data=fo.read()
            expectedpattern='[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+'
            matches=re.finditer(expectedpattern,data)
            if matches:
                
                print ("The email IDs in the file are: ",file)
                for match in matches:
                    print(data[match.start():match.end()])