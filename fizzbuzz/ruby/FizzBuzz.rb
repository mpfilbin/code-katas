#!/usr/bin/env ruby

require 'minitest/autorun'

describe 'FizzBuzzCalc' do

  it 'requires a single argument' do
    method(:fizz_buzz_calc).arity.must_equal 1
  end

  it 'returns 1 if passed a 1' do
    fizz_buzz_calc(1).must_equal 1
  end

  it 'returns 2 if passed a 2' do
    fizz_buzz_calc(2).must_equal 2
  end

  it 'returns "Fizz" if passed 3' do
    fizz_buzz_calc(3).must_equal 'Fizz'
  end

  it 'return 4 if passed 4' do
    fizz_buzz_calc(4).must_equal 4
  end

  it 'returns "Buzz" if passed 5' do
    fizz_buzz_calc(5).must_equal 'Buzz'
  end

  it 'return "Fizz" if passed 6' do
    fizz_buzz_calc(6).must_equal 'Fizz'
  end

  it 'returns "Buzz" if passed 10' do
    fizz_buzz_calc(10).must_equal 'Buzz'
  end

  it 'returns 2 if passed 2 (from cache)' do
    fizz_buzz_calc(2).must_equal 2
  end

  it 'returns "FizzBuzz" if passed 15' do
    fizz_buzz_calc(15).must_equal 'FizzBuzz'
  end

  it 'returns "FizzBuzz" if passed 30' do
    fizz_buzz_calc(30).must_equal 'FizzBuzz'
  end

end

def fizz_buzz_calc(number)
  @cache ||= {}
  output = number

  if @cache.has_key? number
    output = @cache.fetch(number)
  else
    is_divisible_by_three = (number % 3 == 0)
    is_divisible_by_five  = (number % 5 == 0)

    if is_divisible_by_three && is_divisible_by_five
      output = 'FizzBuzz'
    elsif is_divisible_by_five
      output = 'Buzz'
    elsif is_divisible_by_three
      output = 'Fizz'
    end
    @cache.store(number, output)
  end
  output
end

