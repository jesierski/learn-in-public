# Define Class Cake with attributes kind, price, slices in total and remaining pieces

class Item:
    # Constructor for superclass Item
    def __init__(self, item_type, price):
        self.item_type = item_type
        self._price = price

    @property
    def price(self):
        return self._price

class Cake(Item):
    # Constructor for class Cake inheriting item type and price from Item
    def __init__(self, kind, price, slices):
        super().__init__("cake", price)
        assert  isinstance(kind, str)
        self.kind = kind
        assert isinstance(slices, int)
        self.slices = slices
        self.slices_remaining = slices

    # Define class method describe() to print message.
    # Sample: The citron cake costs 24 euros and has 6 slices.
    def describe(self):
        return f"The {self.kind} cake costs {self.price} euros and has {self.slices} pieces."

    # Deduct the sold amount of one cake count of the remaining pieces
    # provided conditions are met
    def sell(self, count):
        if (count <= 0):
            return "Selling of 0 or a negative count not possible!"
        elif (self.slices_remaining-count < 0):
            return f"Selling of more than existing pieces ({self.slices_remaining}) not possible!"
        else:
            self.slices_remaining -= count
            return f"With this cake there are {self.slices_remaining} pieces remaining."

#spice_cake = Cake("Gewürz", 18, 8)
#chocolate_cake = Cake("Schokoladen", 24, 6)
apple_cake = Cake("Apfel", 8, 18)
# Your code is called
# Your result will trigger an AttributeError when price attribute is set.
# This Code may be modified to try different test cases.
result = False
try:
    # Try to set the price attribute.
    apple_cake.price = 17
except AttributeError:
    # The result is True is the price attribute may not be set anew.
    result = True
print(result)