(function(){

  var assert = require('assert');

  describe('LeapYear', function(){
    it('should require a single argument', function(){
      assert.equal(1, isLeapYear.length);
    });

    it('should return false when passed 2001, a typical common year', function () {
        assert.equal(false, isLeapYear(2001));
    });

    it('should return true when passed 1996, a typical leap year', function () {
        assert.equal(true, isLeapYear(1996));
    });

    it('should return false when passed 1900, an atypical common year', function () {
        assert.equal(false, isLeapYear(1900));
    });

    it('should return true when passed 2000, an atypical leap year', function () {
        assert.equal(true, isLeapYear(2000));
    });

  });


  function isLeapYear(year) {
      if (isATypicalCommonYear(year))
          return false;

      return (isTypicalLeapYear(year)); 
  }

  function isTypicalLeapYear(year) {
      return year % 4 == 0;
  }

  function isATypicalCommonYear(year) {
      return year % 100 == 0 && year % 400 != 0;
  }


})();

