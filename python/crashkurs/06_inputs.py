# Example: Proper handling of input types

# Concatenation
x_str = input("Enter the first number (string): ")
y_str = input("Enter the second number (string): ")

print("Concatenation:", x_str + y_str)

# Addition
try:
    x_int = int(input("Enter the first number (integer): "))
    y_int = int(input("Enter the second number (integer): "))
    print("Addition:", x_int + y_int)
except ValueError:
    print("Invalid input. Please enter valid integers.")

