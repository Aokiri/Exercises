# Link to the exercise: https://exercism.org/tracks/python/exercises/armstrong-numbers

def is_armstrong_number(number: int) -> bool:
    result = 0
    for n in str(number):
        result += int(n)**len(str(number))

    return number == result