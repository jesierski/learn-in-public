# Working with string and list objects

# Apply methods to a string
x = "test"
print(f"Index of 'e' in '{x}': {x.find('e')}")
print(f"Index of 't' in '{x}': {x.find('t')}")
print(f"Index of 'u' in '{x}' (not found): {x.find('u')}")  # -1 means not found

# Apply methods to a list
y = []

# Add elements to the list
y.append(100)
y.append(50)
y.append(1000)

# Print the initial list
print(f"\nOriginal list: {y}")

# Sort the list
y.sort()
print(f"Sorted list: {y}")

# Remove an element from the list
y.remove(100)
print(f"List after removing 100: {y}")
