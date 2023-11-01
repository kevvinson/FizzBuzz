using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzGameTest
    {
        [Fact]
        public void Should_return_original_number_when_countoff_given_normal_case()
        {
            //given
            string countResult;
            FizzBuzzGame game = new FizzBuzzGame();

            //when
            countResult = game.CountOff(17);

            //then
            Assert.Equal("17", countResult);
        }
    }
}