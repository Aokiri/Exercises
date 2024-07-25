from string import ascii_lowercase

ALPHABET = set(ascii_lowercase)

def is_pangram(sentence: str) -> bool:
    return ALPHABET.issubset(sentence.lower())