from tkinter import *
import pymysql


def datab():
    db = pymysql.connect("localhost", "root", "", "test")
    cursor = db.cursor()
   
    data = cursor.execute("Select * from FORMLOGIN")
    #data = cursor.execute('''INSERT INTO FORMLOGIN( FIRST_NAME  , LAST_NAME , AGE ) VALUES('Anmol','Nanda',25)''')
   
    a= un.get()
    b = psw.get()
    flag=0
    data = cursor.fetchall()
   
    for i in data:
        if i[0] == a:
            print("Valid Username")
            if i[1] == b:
                print('Successfully logged in')
                break


        else:
            print("Invalid username")

            
    db.commit()
    db.close()





tkit = Tk()

un = StringVar()
L1 = Entry(tkit, text="Username", textvariable=un)
L1.pack(side=TOP)
psw = StringVar()
L2 = Entry(tkit, text="Password", textvariable=psw)
L2.pack(side=TOP)
label = Label(tkit)

E1 = Button(tkit, bd=5, text='Submit', command=datab)
E1.pack(side=BOTTOM)

label.pack()

tkit.mainloop()