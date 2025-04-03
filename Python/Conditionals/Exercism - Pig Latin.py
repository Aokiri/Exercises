# Link to the exercise: https://exercism.org/tracks/python/exercises/pig-latin

def translate(text: str) -> str:
    vowels = "aeiou"
    consonants = "bcdfghjklmnpqrstvwxyz"

    if text[0] in vowels or text.startswith(("xr", "yt")):
        return f"{text}ay"
    