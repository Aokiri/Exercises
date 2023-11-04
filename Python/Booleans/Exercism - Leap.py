# Link to the exercise: https://exercism.org/tracks/python/exercises/leap

def leap_year(year: int) -> bool:
    """
    :param year: int - the year to evaluate if is a leap year.
    :return: bool - true if is a leap year, false if not.
    """

    if year % 400 == 0:
        return True
    elif year % 100 == 0:
        return False
    elif year % 4 == 0:
        return True
    
    return False


##################################################################
##                       Another Solution:                      ##

# def is_leap_year(year):
#    return year % 4 == 0 and (year % 100 != 0 or year % 400 == 0)
##################################################################