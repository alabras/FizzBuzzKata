using Xunit;
using FizzBuzzKata;

namespace FizzBuzzKata.Testing
{
    public class FizzTest
    {       
        [Fact] 
        public void The_number_is_divisible_by_three_then_instead_Fizz(){
            var fizzBuzz = new FizzBuzz();
            
            var result = fizzBuzz.Get(3);

            Assert.Equal("Fizz", result);
        }
    }
}