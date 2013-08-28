/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author l.adams
 */
public class FizzBuzz {
    public FizzBuzz() {
        
    }
    public String FizzBuzzCalc(int value) {
        String result = String.valueOf(value);
        if(value % 3 == 0)
        {
            result = "Fizz";
        }
        return result;
    }
}
