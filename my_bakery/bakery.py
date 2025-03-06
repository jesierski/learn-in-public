# Define Class Cake with attributes kind, price, and slices

class Cake:
    def __init__(self, kind, price, slices):
        self.kind = kind
        self.price = price
        self.slices = slices

# Define class method describe() to print sample message:
# The citron cake costs 24 euros and has 6 slices.

    def describe(self):
        print("The " + self.kind + " cake costs " + self.price + " euros and has " + self.slices + " pieces.")
