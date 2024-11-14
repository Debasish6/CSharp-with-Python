# myscript.py
def greet(name):
    return f"Hello, {name}!"

def addition(a,b):
    return f"The addition is {a+b}"

def student_details(name,roll,_class):
    stu = Student(name,roll,_class)
    stu.display()



class Student:
    def __init__(self,name,roll,_class):
        self.Name = name
        self.Roll = roll
        self._class = _class
    
    def display(self):
        print(f"Name: {self.Name}\nRoll: {self.Roll}\nClass: {self._class}")
    


