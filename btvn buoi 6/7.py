def get_even_list(e):
    for i in e:
        if i%2!=0:
            e.remove(i)
    print(e)
    return(e)
get_even_list([1,2,3,4,5,6,6,7,8,7,9,0])
even_list = get_even_list([1, 2, 5, -10, 9, 6])

if set(even_list)== set([2,-10,6]):
    print("your function is correct")
else:
    print("Oops, bug detected")
