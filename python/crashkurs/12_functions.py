# Functions structure code and define its scope
# Functions with a fixed number of arguments
def add(a, b):
    return a + b


def sub(a, b):
    return a - b


def mul(a, b):
    return a * b


def div(a, b):
    return a / b


# Functions with an arbitrary number of arguments
# *args refers to positional arguments
# *args is a list
def add_all(*args):
    result = 0
    for arg in args:
        result += arg
    return result


# Functions with arguments and keyword arguments
# **kwargs refers to keyword arguments
# **kwargs is a dictionary
def add_all_kw(*args, **kwargs):
    result = 0
    for arg in args:
        result += arg
        print(f"arg: {arg}")
    for key, value in kwargs.items():
        result += value
        print(f"kwarg: {value}")
    return result


# Display the output of each function
def main():
    print(add(1, 2))
    print(sub(1, 2))
    print(mul(1, 2))
    print(div(1, 2))
    print(add_all(1, 2, 3, 4, 5))
    print(add_all_kw(1, 2, 3, x=4, y=5))


if __name__ == "__main__":
    main()
