namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public string Get(int number){
            if(number % 3 == 0)
                return "Fizz";
            return number.ToString();
        }
    }
}