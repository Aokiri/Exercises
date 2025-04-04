# Link to the exercise: https://exercism.org/tracks/python/exercises/perfect-numbers

def classify(number: int) -> str:
    """ A perfect number equals the sum of its positive divisors.

    :param number: int a positive integer
    :return: str the classification of the input integer
    """
    if number < 1:
        raise ValueError("Classification is only possible for positive integers.")
    
    aliquot_sum: int = 0
    for num in range(1, number):
        if number % num == 0:
            aliquot_sum += num
    
    if number < aliquot_sum:
        return "abundant"
    elif number == aliquot_sum:
        return "perfect"
    return 'deficient'