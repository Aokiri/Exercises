# Link to the exercise: https://exercism.org/tracks/python/exercises/darts

from math import sqrt

def score(x: float, y: float) -> float:
    distance: float = sqrt(x**2 + y**2)
    
    if distance <= 1:
        return 10
    elif distance <= 5:
        return 5
    elif distance <= 10:
        return 1
    return 0