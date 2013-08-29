/**
 *
 * @author l.adams
 */
public class FizzBuzz {
    public FizzBuzz() {
        
    }
    public String FizzBuzzCalc(int value) {
        String result = String.valueOf(value);
        
        if (value % 15 == 0)
        {
            result = "Fizz Buzz";
        }
        else if(value % 3 == 0)
        {
            result = "Fizz";
        }
        else if(value % 5 == 0)
        {
            result = "Buzz";
        }
        return result;
    }
}
