using NUnit.Framework;

namespace rdttest
{
    public class Tests
    {

        FizzBuzz Fb;

        [SetUp]
        public void Setup()
        {
            Fb = new FizzBuzz();
        }

        ///  Replace() Test

        [Test]
        public void DivideBy3()
        {
            var Result = Fb.Replace(3);

            Assert.That(Result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void DivideBy5()
        {
            var Result = Fb.Replace(5);

            Assert.That(Result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void DivideBy15()
        {
            var Result = Fb.Replace(15);

            Assert.That(Result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void DivideBy8()
        {
            var Result = Fb.Replace(8);

            Assert.That(Result, Is.EqualTo("8"));
        }

        /// Incremental Test 

        [Test]
        public void IncrementalCount()
        {
            var Result = Fb.Incremental(1, 100).Count();

            Assert.That(Result, Is.EqualTo(100));
        }

        [Test]
        public void IncrementalResultCheck1()
        {
            var Result = Fb.Incremental(1, 100)[14];

            Assert.That(Result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void IncrementalResultCheck2()
        {
            var Result = Fb.Incremental(1, 100)[4];

            Assert.That(Result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void IncrementalResultCheck3()
        {
            var Result = Fb.Incremental(1, 100)[2];

            Assert.That(Result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void IncrementalResultCheck4()
        {
            var Result = Fb.Incremental(1, 100)[12];

            Assert.That(Result, Is.EqualTo("13"));
        }
    }
}