from turtle import *
ask = int(input("Length :"))
ask2 = input("Colour :")
def draw_square( length, cl):
    color(cl)
    for i in range (4):
        forward(length)
        left (90) 
draw_square(ask,ask2)
