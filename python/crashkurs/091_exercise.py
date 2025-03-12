#################################
# Game to guess a random number #
#################################

# Generate random number to be guessed
from random import randint

min_no = 0 # Minimum random_number
max_no = 10 # Maximum random_number

random_number = randint(min_no, max_no)

max_tries = 3  # Maximum number of attempts

# Number of user tries
tries = 0

# User is asked to input number within randint
while True:
    try:
        # Prompt the user for a guess
        user_number = int(input(f"Guess a number between {min_no} and {max_no}: "))

        # Check the user's guess
        if user_number == random_number:
            print(f"You guessed it! The random number was {random_number}.")
            break
        elif user_number < random_number:
            print(f"Try {tries} too low!")
        else: # user_number > random_number
            print(f"Try {tries} too high!")
        tries += 1
    except ValueError:
        print("Invalid input. Please enter a valid integer.")
        continue
    if tries == max_tries:
        print(f"Sorry, you lost! The number was {random_number}.")
        break
