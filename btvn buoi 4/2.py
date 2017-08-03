while True:
    price={
        "banana": 4,
        "apple": 2,
        "orange": 1.5,
        "pear": 3
    }
    print (price)
    purchased_item = []
    ask = input("what do you want to buy ??")
    quantity = int(input("Quantity ?"))
    purchased_item.append(ask)
    print(ask,", Quantity:",quantity,", unit price:",price[ask])
    total = price[ask] * quantity
    print("purchased item: ", purchased_item,":", quantity)
    print("total :",total)
    total = 0
