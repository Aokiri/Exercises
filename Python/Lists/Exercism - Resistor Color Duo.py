# Link to the exercise: https://exercism.org/tracks/python/exercises/resistor-color-duo

color_dict: dict = {'black': 0, 'brown': 1, 'red': 2, 'orange': 3, 'yellow': 4, 
                        'green': 5, 'blue': 6, 'violet': 7, 'grey': 8, 'white': 9}

def value(colors: list) -> int:
    color_number: str = f"{color_dict[colors[0]]}{color_dict[colors[1]]}"
    return int(color_number)