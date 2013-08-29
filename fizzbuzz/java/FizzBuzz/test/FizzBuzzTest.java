/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

import junit.framework.Assert;
import org.junit.Before;
import org.junit.Test;

/**
 *
 * @author l.adams
 */
public class FizzBuzzTest {
    
    FizzBuzz fizzBuzz;
    public FizzBuzzTest() {
    }
    
    @Before
    public void setUp() {
        fizzBuzz = new FizzBuzz();
    }

    @Test
    public void passingInOneShouldReturnOne() {
        String result = fizzBuzz.FizzBuzzCalc(1);
        Assert.assertEquals("1", result);
    }
    @Test
    public void passingInTwoSHouldReturnTwo() {
        String result = fizzBuzz.FizzBuzzCalc(2);
        Assert.assertEquals("2", result);
    }
    
    @Test
    public void passingInThreeShouldReturnFizz() 
    {
        String result = fizzBuzz.FizzBuzzCalc(3);
        Assert.assertEquals("Fizz", result);
    }
    
    @Test
    public void passingInSixShouldReturnFizz()
    {
        String result = fizzBuzz.FizzBuzzCalc(6);
        Assert.assertEquals("Fizz", result);
    }
    
    @Test
    public void passingInFiveShouldReturnBuzz()
    {
        String result = fizzBuzz.FizzBuzzCalc(5);
        Assert.assertEquals("Buzz", result);
    }
    
    @Test
    public void passingInFifteenShouldReturnFizzBuzz()
    {
        String result = fizzBuzz.FizzBuzzCalc(15);
        Assert.assertEquals("Fizz Buzz", result);
    }
}