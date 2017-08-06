from turtle import *
x = int(input("Your X Position:"))
y = int(input("Your Y Position:"))
lenght = int(input("Your side's length of STAR:"))
def drawstar():
     penup()
     forward(x)
     left(90)
     forward(y)
     right(54)
     pendown()
     for i in range (5):
          forward(lenght)
          left(144)
          
drawstar()
