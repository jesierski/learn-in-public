# Define Class Cake with attributes kind, price, and slices
from pydoc import describe


class Cake:
    # Constructor for class Cake
    def __init__(self, kind, price, slices):
        assert  isinstance(kind, str)
        self.kind = kind
        assert  isinstance(price, int)
        self.price = price
        assert isinstance(slices, int)
        self.slices = slices

    # Define class method describe() to print message.
    # Sample: The citron cake costs 24 euros and has 6 slices.
    def describe(self):
        return f"The {self.kind} cake costs {self.price} euros and has {self.slices} pieces."

spice_cake = Cake("Gewürz", 18, 8)
chocolate_cake = Cake("Schokoladen", 24, 6)
print(Cake.describe(spice_cake))
print(Cake.describe(chocolate_cake))