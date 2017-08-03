inventory = {
    'gold' : [500,21,4634,34,23],
    'pouch' : ['flint', 'twine', 'gemstone'],
    'backpack' : ['xylophone', 'dagger', 'bedroll', 'bread loaf']
}
inventory["pocket"]= ["seashell","strange berry", "lint"]
inventory['backpack'].sort()
inventory["backpack"].remove('dagger')
print(inventory)
inventory["gold"].append(50)
print(inventory)
