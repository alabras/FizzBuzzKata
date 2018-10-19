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

        [Fact]
        public void The_number_is_divisible_by_five_then_instead_Buzz(){
            var fizzBuzz = new FizzBuzz();

            var result = fizzBuzz.Get(5);

            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void The_number_is_divisible_by_three_and_five_then_instead_FizzBuzz(){
            var fizzBuzz = new FizzBuzz();

            var result = fizzBuzz.Get(15);

            Assert.Equal("FizzBuzz", result);
        }
    }
}