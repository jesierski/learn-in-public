# Error handling to ensure program ends gracefully
try:
    given = int(input("Enter an integer: "))
    result = 10 / given
# Try to handle errors as exactly as possible
except ZeroDivisionError as e:
    print("Division by zero:", e)
    result = None
except TypeError as e:
    print("Invalid type:", e)
    result = None
except ValueError as e:
    print("Invalid value:", e)
    result = None
finally:
    # Code within 'finally' block always executes, regardless of exceptions
    print("Execution completed.")

# Display the result
print("Result: ", result)
