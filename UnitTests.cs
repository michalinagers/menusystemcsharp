using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Menu.UnitTest
{
    [TestClass]
    public class TrinaryTests  
    {
        [TestMethod]
        public void Converter_UserInputInvalid_ReturnsTrue() //tests for invalid input (invalid trinary numbers)
        {

            var trinary = new Trinary();
            var results = trinary.Converter(new UserInput { Invalid = true });
            Assert.IsTrue(results);

        }

        [TestMethod]
        
        public void Converter_TrinaryIsValid_ReturnsTrue()
        {
            var trinary = new TrinaryNumber();
            var result = trinary.IsValid(true);
            Assert.IsTrue(result);
        }

        [TestMethod]

        public void Converter_UserInputCharacters_ReturnsFalse()  //tests for characters not including trinary or non trinary numbers)
        {

            var trinary = new Trinary();
            var results = trinary.Converter(new UserInput { Input = "AaEebD" });
            Assert.IsFalse(results);
        }
    }
}

//https://www.youtube.com/watch?v=aq3IbO0RwAQ&ab_channel=TeddySmith, https://www.youtube.com/watch?v=HYrXogLj7vg&ab_channel=ProgrammingwithMosh, https://www.youtube.com/watch?v=m863B7Eb6I4&ab_channel=tutorialsEU-C%23 these are the YouTube videos which I watched to get a better understanding about unit testing.
