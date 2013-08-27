#!/usr/bin/env python

import unittest
import inspect

def FizzBuzzCalc(number):
    output = number
    isDivisibleByThree = (number % 3 is 0)
    isDivisibleByFive = (number % 5 is 0)

    if isDivisibleByThree and isDivisibleByFive:
        output = "FizzBuzz"
    elif isDivisibleByThree:
        output = "Fizz"
    elif isDivisibleByFive:
        output = "Buzz"

    return output


class FizzBuzzCalcTest(unittest.TestCase):
    def testRequiresSingleArgument(self):
        arguments = inspect.getargspec(FizzBuzzCalc).args
        self.assertEqual(1, len(arguments))

    def testWhenPassedOneReturnsOne(self):
        self.assertEqual(1, FizzBuzzCalc(1))

    def testWhenPassedTwoReturnsTwo(self):
        self.assertEqual(2, FizzBuzzCalc(2))

    def testWhenPassedThreeReturnsFizz(self):
        self.assertEqual('Fizz', FizzBuzzCalc(3))

    def testWhenPassedFourReturnsFour(self):
        self.assertEqual(4, FizzBuzzCalc(4))

    def testWhenPassedFiveReturnsBuzz(self):
        self.assertEqual('Buzz', FizzBuzzCalc(5))

    def testWhenPassedSixReturnsFizz(self):
        self.assertEqual('Fizz', FizzBuzzCalc(6))

    def testWhenPassed10ReturnsBuzz(self):
        self.assertEqual('Buzz', FizzBuzzCalc(10))

    def testWhenPassed12ReturnsFizz(self):
        self.assertEqual('Fizz', FizzBuzzCalc(12))

    def testWhenPassedFifteenReturnsFizzBuzz(self):
        self.assertEqual('FizzBuzz', FizzBuzzCalc(15))

    def testWhenPassedThirtyReturnsFizzBuzz(self):
        self.assertEqual('FizzBuzz', FizzBuzzCalc(30))

if __name__ == '__main__':
    unittest.main()