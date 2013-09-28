require 'minitest/spec'
require 'minitest/autorun'
require 'minitest/reporters'
MiniTest::Reporters.use!
require_relative '../string_calc'

describe 'StringCalc' do

  describe 'class methods' do

    describe '#add' do

      describe 'when passed an empty string' do

        it 'returns zero' do
          StringCalc.add('').must_equal 0
        end

      end

      describe 'when passed a single value' do
        it 'returns that value' do
          StringCalc.add('3').must_equal 3
        end
      end

      describe 'when passed two, comma-delimited values' do
        it 'returns the sum of those two values' do
          StringCalc.add('3,4').must_equal 7
        end
      end

      describe 'when passed three, comma-delimited values' do
        it 'returns the sum of those values' do
          StringCalc.add('3,4,5').must_equal 12
        end
      end

      describe 'when a newline character (\n) is added between values' do
        it 'is ignored and the values are summed as if it were not there' do
          StringCalc.add("1, 2, \n 3").must_equal 6
        end
      end

      describe 'when passing a comma-delimited string of values that contain negative integers' do
        it 'throws an exception' do
          lambda {
            StringCalc.add('1,-2,4')
          }.must_raise StringCalc::ArithmeticError
        end

        it 'includes a list of the negative values in the message from the exception' do
          exception = lambda {
            StringCalc.add('1,-2,4')
          }.must_raise StringCalc::ArithmeticError

          exception.message.must_equal 'Values cannot include: -2'
        end
      end

      describe 'when passed a custom delimiter as the second argument' do
        it 'uses that delimiter to split the strings and sum the values' do
          StringCalc.add('1#2#3', '#').must_equal 6
        end
      end

      describe 'when passed invalid input (e.g. alpha/symbol)' do
        it 'returns zero' do
          StringCalc.add('1,a,$,2').must_equal 0
        end
      end

    end

  end

end