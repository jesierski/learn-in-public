# Dictionary is defined x = {"key1": value1, "key2": value2}

# Demonstrating identical hash values for integers and floats

# Dictionary with keys 1 (int) and 1.0 (float)
x = {1: 5, 1.0: 10}
print(f"Dictionary: {x}")

# Explanation: Keys with the same hash values can't co-exist as distinct keys in a dictionary.
# Here, 1 (int) and 1.0 (float) share the same hash, resulting in only one key being stored.

# Display the hash values of 1 (int) and 1.0 (float)
hash_1 = hash(1)
hash_1_float = hash(1.0)
print(f"Hash of 1 (int): {hash_1}")
print(f"Hash of 1.0 (float): {hash_1_float}")

# Explain the issue
if hash_1 == hash_1_float:
    print("\n⚠️ Note: Since 1 and 1.0 have the same hash and are considered equal, "
          "only one key is stored in the dictionary.")
print() # Insert empty row for prettier output

# Safely accessing dictionary keys using the get() method

# Define a dictionary
x = {"key1": 4, "key2": 32}

# Access keys using the get() method with a default value
value_key1 = x.get("key1", 1000)  # Key exists, returns the actual value
value_key3 = x.get("key3", 1000)  # Key does not exist, returns the default value

# Print results
print(f"Value for 'key1': {value_key1}")  # Output: 4
print(f"Value for 'key3' (default value): {value_key3}")  # Output: 1000
print()  # Insert an empty row for cleaner output

# Useful methods

# Print all keys, values, and key-value pairs
print("Keys:",
      x.keys())
print("Values:",
      x.values())
print("Items:",
      x.items())

# Convert items to a list (useful for processing key-value pairs)
print("\nItems as a list:",
      list(x.items()))

# Iterate over key-value pairs
print("\nIterating over key-value pairs:")
for key, value in x.items():
    print(key, value)
