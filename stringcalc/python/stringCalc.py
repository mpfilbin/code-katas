#! /usr/bin/env python

def add(values, delimiter=","):
    """
        add(string [, string]) -> int

        Accepts two arguments. The first is a string of delimited, non-negative integer values to be summed. The second
        is the delimiter used to separate the values. If no delimiter value is passed, it is assumed that the string is
        delimited by commas (,).

        stringCalc.add("1,2,3") -> 6
        stringCalc.add("1;2;3", ";") -> 6

        If a negative value is passed in the string, an ArithemticError is raised containing a list of the negative values
        passed to the function.

        If any values in the string are non-numeric (except for the delimiter), a zero result is returned
    @rtype : int
    """
    values = __convert_string_to_int_list(values, delimiter)
    if len(values) is 0:
        result = len(values)
    else:
        if len(values) is 1:
            result = values.pop()
        else:
            result = reduce(lambda x, y: x + y, values)
    return result


def __convert_string_to_int_list(string, delimiter):
    values = string.split(delimiter)
    try:
        values = [int(value) for value in values]
    except ValueError:
        values = [0]
    __check_for_negative_values(values)
    return values


def __check_for_negative_values(values):
    negatives = filter(lambda x: x < 0, values)
    if len(negatives) > 0:
        raise ArithmeticError("Input cannot contain negative values: %s" % ",".join(map(lambda x: str(x), negatives)))