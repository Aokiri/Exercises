# Link to the exercise: https://exercism.org/tracks/python/exercises/collatz-conjecture

def steps(number: int) -> int:
    """Implementation of the Collatz Conjecture"""
    
    # If the number is not in N*, raise an error
    if number <= 0: 
        raise ValueError("Only positive integers are allowed")
        
    # Here is the counter (always count from the first iteration)
    counter: int = 0
    while number != 1:
        # If the number is odd, divide by 2
        if number % 2 == 0:
            number /= 2
        # If the number is even, multiply by 3 and add 1
        else:
            number = number*3 + 1
        # Increase our counter
        counter += 1
    # Return the total steps performed to reach 1
    return counter