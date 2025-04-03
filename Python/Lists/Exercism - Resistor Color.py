# Link to the exercise: https://exercism.org/tracks/python/exercises/resistor-color

color_dict: dict = {'black': 0, 'brown': 1, 'red': 2, 'orange': 3, 'yellow': 4, 
                        'green': 5, 'blue': 6, 'violet': 7, 'grey': 8, 'white': 9}

def color_code(color: str) -> int:
    return color_dict[color]

def colors():
    return list(color_dict)