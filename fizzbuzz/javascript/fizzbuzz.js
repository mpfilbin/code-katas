(function(){

  var assert = require('assert');

  describe('FizzBuzz', function(){
    it('should require a single argument', function(){
      assert.equal(1, fizzBuzzCalc.length);
    });

    it('should return a 1 when passed a 1', function(){
      assert.equal(1, fizzBuzzCalc(1));
    });

    it('should return a 2 when passed a 2', function(){
      assert.equal(2, fizzBuzzCalc(2));
    });

    it('should return a "Fizz" when passed a 3', function(){
      assert.equal("Fizz", fizzBuzzCalc(3));
    });

    it('should return a 4 when passed a 4', function(){
      assert.equal(4, fizzBuzzCalc(4));
    });

    it('should return "Buzz" when passed a 5', function(){
      assert.equal("Buzz", fizzBuzzCalc(5));
    });

    it('should return "Fizz" when passed a 6', function(){
      assert.equal("Fizz", fizzBuzzCalc(6));
    });

    it('should return 7 when passed a 7', function(){
      assert.equal(7, fizzBuzzCalc(7));
    });

    it('should return "Buzz" when passed a 10', function(){
      assert.equal("Buzz", fizzBuzzCalc(10));
    });

    it('should return "FizzBuzz" when passed a 15', function(){
      assert.equal("FizzBuzz", fizzBuzzCalc(15));
    });

    it('should return "FizzBuzz" when passed a 30', function(){
      assert.equal("FizzBuzz", fizzBuzzCalc(30));
    });

  });

  function fizzBuzzCalc(number){
    var output = number,
        isDivisibleByThree = (number % 3 == 0),
        isDivisibleByFive = (number % 5 == 0);

    if(isDivisibleByThree && isDivisibleByFive){
      output = 'FizzBuzz';
    } else if (isDivisibleByFive){
      output = 'Buzz';
    } else if (isDivisibleByThree){
      output = 'Fizz';
    }

    return output;
  }

})();

