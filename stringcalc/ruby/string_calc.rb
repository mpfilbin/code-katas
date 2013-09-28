#! /usr/bin/env ruby

class StringCalc

  class ArithmeticError < RuntimeError
  end

  class << self

    def add(string, delimiter=',')
      values = []
      invalids = string.scan(/\D/).find_all { |x| ![delimiter, '-', "\s", "\n"].include?(x) }
      values   = string.split(delimiter).map { |value| value.to_i } if invalids.empty?
      if values.length > 0
        negatives = values.find_all { |num| num < 0 }
        unless negatives.empty?
          raise StringCalc::ArithmeticError, "Values cannot include: #{negatives.join(',')}"
        end
        values.inject { |sum, num| sum + num }
      else
        0
      end
    end

  end

end