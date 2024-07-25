TOTAL_SQUARES = 64

def square(number: int) -> int:
    if 64 < number or number < 1:
        raise ValueError("square must be between 1 and 64")
    else:
        return 2 ** (number - 1)
        
def total():
    return 2 ** TOTAL_SQUARES - 1
