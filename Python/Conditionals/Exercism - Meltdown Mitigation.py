# Link to the exercise: https://exercism.org/tracks/python/exercises/meltdown-mitigation

"""Functions to prevent a nuclear meltdown."""

from typing import Union

MAX_TEMPERATURE: int = 800
MIN_NEUTRONS_EMITED: int = 500
MAX_TEMP_PER_NEUTRONS: float = 5e5

def is_criticality_balanced(temperature: Union[int, float], neutrons_emitted: Union[int, float]) -> bool:
    """Verify criticality is balanced.

    :param temperature: int or float - temperature value in kelvin.
    :param neutrons_emitted: int or float - number of neutrons emitted per second.
    :return: bool - is criticality balanced?
    """
    if temperature < MAX_TEMPERATURE and neutrons_emitted > MIN_NEUTRONS_EMITED:
        return (temperature * neutrons_emitted) < MAX_TEMP_PER_NEUTRONS
    
    return False


def reactor_efficiency(voltage: Union[int, float], current: Union[int, float], theoretical_max_power: Union[int, float]) -> str:
    """Assess reactor efficiency zone.

    :param voltage: int or float - voltage value.
    :param current: int or float - current value.
    :param theoretical_max_power: int or float - power that corresponds to a 100% efficiency.
    :return: str - one of ('green', 'orange', 'red', or 'black').

    Efficiency can be grouped into 4 bands:

    1. green -> efficiency of 80% or more,
    2. orange -> efficiency of less than 80% but at least 60%,
    3. red -> efficiency below 60%, but still 30% or more,
    4. black ->  less than 30% efficient.
    """

    generated_power = voltage * current
    efficiency_percentage = (generated_power / theoretical_max_power) * 100

    match efficiency_percentage:
        case ep if ep >= 80:
            return "green"
        case ep if 80 > ep >= 60:
            return "orange"
        case ep if 60 > ep >= 30:
            return "red"
        case ep if ep < 30:
            return "black"
        case _:
            return "Percentage not found."


def fail_safe(temperature: Union[int, float], neutrons_produced_per_second: Union[int, float], threshold: Union[int, float]) -> str:
    """Assess and return status code for the reactor.

    1. 'LOW' -> `temperature * neutrons per second` < 90% of `threshold`
    2. 'NORMAL' -> `temperature * neutrons per second` +/- 10% of `threshold`
    3. 'DANGER' -> `temperature * neutrons per second` is not in the above-stated ranges

    :param temperature: int or float - value of the temperature in kelvin.
    :param neutrons_produced_per_second: int or float - neutron flux.
    :param threshold: int or float - threshold for category.
    :return: str - one of ('LOW', 'NORMAL', 'DANGER').
    """

    temperature_per_neutrons = temperature * neutrons_produced_per_second
    low_threshold = 0.9 * threshold
    high_threshold = 1.1 * threshold

    match temperature_per_neutrons:
        case tpn if tpn < low_threshold:
            return "LOW"
        case tpn if low_threshold <= tpn <= high_threshold:
            return "NORMAL"
        case _:
            return "DANGER"