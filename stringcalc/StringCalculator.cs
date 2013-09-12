using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace StringCalc
{
    public class StringCalculator
    {

        private string _defaultDelimiter = ",";

        public int Add(string input)
        {
            var result = 0;
            if (IsNonEmptyString(input))
            {
                input = NormalizeStringForValidValues(input);
                var numberArray = GetArrayFromInput(input);
                result = SumArray(numberArray);
            }
            return result;
        }

        private int[] GetArrayFromInput(string input)
        {
            try
            {
                var result = input.Split(',').Select(s => int.Parse(s));
                CheckForInvalidNegativeNumbers(result);
                return result.ToArray();
            }
            catch(FormatException ex)
            {
                return new int[0];
            }
        }

        private void CheckForInvalidNegativeNumbers(IEnumerable<int> result)
        {
            if (result.Any(x => x < 0))
            {
                var invalidNumbers = result.Where(x => x < 0);
                var message = "Input cannot contain negative numbers: ";
                foreach (var invalidNumber in invalidNumbers)
                {
                    message += invalidNumber + ",";
                }
                message = message.Substring(0, message.Length - 1);
                throw new ArgumentException(message);
            }
        }

        private bool IsNonEmptyString(string input)
        {
            return !string.IsNullOrEmpty(input);
        }

        private int SumArray(int[] input)
        {
            try
            {
                return input.Sum();
            }
            catch
            {
                return 0;
            }
        }

        private string NormalizeStringForValidValues(string input)
        {
            var delimiter = _defaultDelimiter;
            if(input.StartsWith("//"))
            {
                delimiter = input.Substring(2, 1);
                input = input.Substring(4).Replace(delimiter, _defaultDelimiter);
            }
            return input.Replace('\n', ',');
        }
    }
}