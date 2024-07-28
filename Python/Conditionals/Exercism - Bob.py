def response(hey_bob):
    sentence = hey_bob.strip()
    isyelling = hey_bob.isupper()

    if isyelling and sentence.endswith('?'):
        return "Calm down, I know what I'm doing!"
    
    elif sentence is "":
        return "Fine. Be that way!"
    
    elif sentence.endswith('?'):
        return "Sure."
    
    elif isyelling:
        return "Whoa, chill out!"
    
    else:
        return "Whatever."