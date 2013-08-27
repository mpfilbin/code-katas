import unittest
import inspect
from FizzBuzz import fizzBuzzCalc

class FizzBuzzTest(unittest.TestCase):
    def calc_expects_two_args(self):
        arguments = inspect.getargspec(fizzBuzzCalc).args
        self.assertEqual(1, len(arguments))

unittest.main()