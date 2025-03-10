# Define Class Cake with attributes kind, price, slices in total and remaining pieces

class Item:
    # Constructor for class Item
    def __init__(self, item_type, price):
        self.item_type = item_type
        self.price = price

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

spice_cake = Cake("Gewürz", 18, 8)
chocolate_cake = Cake("Schokoladen", 24, 6)