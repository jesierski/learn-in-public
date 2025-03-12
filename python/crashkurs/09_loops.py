# Define the list
x = [1, 2, 3, 4, 5, 6]

# Multiply each item in the list by 2 using a for loop
print("List items multiplied by 2:", end=" ")
for item in x:
    print(item * 2, end=" | ")
print()  # Add a newline for clean output


# Use a for loop to process the list, multiplying item 4 differently
print("List items (item 4 multiplied by 10):", end=" ")

for item in x:
    if item == 4:
        # Special case for item 4
        print(item * 10, end=" | ")
        # Do nothing with "continue"
        # Or leave the loop with "break"
    else:
        # Default case for all other items
        print(item * 2, end=" | ")
print()  # Add a newline for clean output

# Define the list anew
x = [14, 211, 32, 4, 5534, 6234]

# Iterate through the list using a for loop with enumerate
print("Using for loop with index:")
for index, item in enumerate(x):
    print(f"Index {index}: {item}")

# Iterate through the first three elements using a while loop
print("\nUsing while loop (first 3 items):")
i = 0
while i < min(3, len(x)):  # Ensure the index doesn't exceed the list length
    print(f"Index {i}: {x[i]}")
    i += 1
