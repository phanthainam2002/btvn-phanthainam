from turtle import *
x = int(input("Your X Position:"))
y = int(input("Your Y Position:"))
lenght = int(input("Your side's length of STAR:"))
def draw_star():
     penup()
     forward(x)
     left(90)
     forward(y)
     right(54)
     pendown()
     for i in range (5):
          forward(lenght)
          left(144)
          
draw_star()
speed(0)
color('blue')
for i in range(100):
    import random
    x = random.randint(-300, 300)
    y = random.randint(-300, 300)
    length = random.randint(3, 10)
    draw_star()

