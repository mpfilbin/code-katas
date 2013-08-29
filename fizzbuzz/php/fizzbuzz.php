<?php

require_once(dirname(__FILE__).'/../../lib/php/simpletest/autorun.php');

class FizzBuzzTest extends UnitTestCase{
  function testRequiresOneArgument(){
    $reflection = new ReflectionClass('FizzBuzz');
    $reflectionMethod = $reflection->getMethod('calc');
    $this->assertTrue($reflectionMethod->getNumberOfParameters());
  }
  
  function testReturnsOneWhenPassedOne(){
      $this->assertEqual(1, FizzBuzz::calc(1));
  }
  
  function testReturnsTwoWhenPassedTwo(){
      $this->assertEqual(2, FizzBuzz::calc(2));
  }
  
  function testReturnsFizzWhenPassedThree(){
      $this->assertEqual('Fizz', FizzBuzz::calc(3));
  }
  
  function testReturnsFourWhenPassedFour(){
      $this->assertEqual(4, FizzBuzz::calc(4));
  }
  
  function testReturnsBuzzWhenPassedFive(){
      $this->assertEqual("Buzz", FizzBuzz::calc(5));
  }
  
  function testReturnsFizzWhenPassedSix(){
      $this->assertEqual("Fizz", FizzBuzz::calc(6));
  }
  
  function testReturnsSevenWhenPassedSeven(){
      $this->assertEqual(7, FizzBuzz::calc(7));
  }
  
  function testReturnsBuzzWhenPassedTen(){
      $this->assertEqual("Buzz", FizzBuzz::calc(10));
  }
  
  function testReturnsFizzWhenPassedTwelve(){
      $this->assertEqual("Fizz", FizzBuzz::calc(12));
  }
  
  function testReturnsFizzBuzzWhenPassedFifteen(){
      $this->assertEqual("FizzBuzz", FizzBuzz::calc(15));
  }
  
  function testReturnsFizzBuzzWhenPassedThirty(){
      $this->assertEqual("FizzBuzz", FizzBuzz::calc(30));
  }
}

class FizzBuzz{
    
    public static function calc($value){
        $output = $value;
        $isDivisibleByThree = ($value % 3 == 0);
        $isDivisibleByFive = ($value % 5 == 0);
        if($isDivisibleByThree && $isDivisibleByFive){
            $output = "FizzBuzz";
        } elseif ($isDivisibleByFive) {
            $output = "Buzz";
        } elseif ($isDivisibleByThree) {
            $output = "Fizz";
        }
        return $output;
    }
}

?>
