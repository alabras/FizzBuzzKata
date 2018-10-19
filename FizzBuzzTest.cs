using Xunit;
using FizzBuzzKata;

namespace FizzBuzzKata
{
    public class FizzBuzzTest
    {
        private FizzBuzz _fizzBuzz;
        public FizzBuzzTest()
        {
            _fizzBuzz = new FizzBuzz();
        }
        [Fact] 
        public void The_number_is_divisible_by_three_then_instead_Fizz(){
            
            var result = _fizzBuzz.Get(3);

            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void The_number_is_divisible_by_five_then_instead_Buzz(){

            var result = _fizzBuzz.Get(5);

            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void The_number_is_divisible_by_three_and_five_then_instead_FizzBuzz(){

            var result = _fizzBuzz.Get(15);

            Assert.Equal("FizzBuzz", result);
        }
    }
}