import unittest
import inspect

def IsLeapYear(year):
    isTypicalLeapYear = (year % 4 is 0)
    isATypicalCommonYear = (year % 100 is 0 and year % 400 is not 0)

    if isATypicalCommonYear:
        return False

    return isTypicalLeapYear


class LeapYearTest(unittest.TestCase):
    def testRequiresSingleArgument(self):
        arguments = inspect.getargspec(IsLeapYear).args
        self.assertEqual(1, len(arguments))

    def testWhenPassingInTypicalCommonYearShouldReturnFalse(self):
        self.assertEqual(False, IsLeapYear(2001))

    def testWhenPassingInTypicalLeapYearShouldReturnTrue(self):
        self.assertEqual(True, IsLeapYear(1996))

    def testWhenPassingInATypicalCommonYearShouldReturnFalse(self):
        self.assertEqual(False, IsLeapYear(1900))

    def testWhenPassingInATypicalLeapYearShouldReturnTrue(self):
        self.assertEqual(True, IsLeapYear(2000))

if __name__ == '__main__':
    unittest.main()