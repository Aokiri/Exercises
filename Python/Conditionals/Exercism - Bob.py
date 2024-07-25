def response(hey_bob):
    sentence = hey_bob.strip()
    isyelling = hey_bob.isupper()

    if isyelling and sentence[-1] is "?":
        return "Calm down, I know what I'm doing!"
    
    elif sentence is "":
        return "Fine. Be that way!"
    
    elif sentence[-1] is "?":
        return "Sure."
    
    elif isyelling:
        return "Whoa, chill out!"
    
    else:
        return "Whatever."