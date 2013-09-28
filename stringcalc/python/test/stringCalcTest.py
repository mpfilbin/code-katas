#! /usr/bin/env python

__author__ = 'mpfilbin'

import unittest
import stringCalc


class ExtendedTestCase(unittest.TestCase):
    def assertRaisesWithMessage(self, msg, func, *args, **kwargs):
        try:
            func(*args, **kwargs)
            self.assertFail()
        except Exception as inst:
            self.assertEqual(inst.message, msg)


class StringCalcTest(ExtendedTestCase):
    def test_it_has_an_add_method(self):
        self.assertTrue(hasattr(stringCalc, "add"))

    def test_passing_empty_string_returns_zero(self):
        self.assertEquals(0, stringCalc.add(""))

    def test_passing_a_single_value_returns_that_value(self):
        self.assertEquals(1, stringCalc.add("1"))

    def test_passing_two_values_returns_the_sum_of_those_values(self):
        self.assertEquals(3, stringCalc.add("1,2"))

    def test_passing_three_values_returns_the_sum_of_those_values(self):
        self.assertEquals(18, stringCalc.add("5,6,7"))

    def test_padding_new_line_between_values_should_be_ignored(self):
        self.assertEquals(18, stringCalc.add("5,6\n,7"))

    def test_passing_a_negative_number_should_throw_exception(self):
        self.assertRaises(ArithmeticError, stringCalc.add, "-5,6,7")

    def test_passing_custom_delimiter_should_user_delimiter_and_sum_values(self):
        self.assertEquals(18, stringCalc.add("5;6;7", ";"))

    def test_passing_negative_numbers_should_have_exception_with_negative_numbers_in_message(self):
        self.assertRaisesWithMessage("Input cannot contain negative values: -5,-6", stringCalc.add, '-5,-6,7')

    def test_sending_invalid_input_returns_zero(self):
        self.assertEquals(0, stringCalc.add("5,6,&,a,^,7"))

if __name__ == '__main__':
    unittest.main()
