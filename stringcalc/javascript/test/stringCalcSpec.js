var should = require('should');
var stringCalc = require('./../stringCalc.js');

describe("stringCalc", function() {
	
	it("It is an object that exists", function(){
		should.exist(stringCalc);
		stringCalc.should.be.a("object");
	});

	describe("stringCalc.add",function(){
		it("should be a function", function(){
			should.exist(stringCalc.add);
		});

		describe("when passed an empty string", function(){
			it("should return 0", function(){
				(stringCalc.add('')).should.equal(0);	
			});
		});

		describe("when passed in a single value", function(){
			it("should return that value", function(){
				(stringCalc.add('1')).should.equal(1);
			});
		});

		describe("when passed in two values", function(){
			it("should return the sum of those values", function(){
				(stringCalc.add('1,2')).should.equal(3);
			});
		});

		describe("when calling Add with a negative number will throw an exception", function() {
			it("should throw an exception because of a negative number", function() {
				(function() {
					stringCalc.add('1,-1');
				}).should.throw();
			});
		});

	});
});
