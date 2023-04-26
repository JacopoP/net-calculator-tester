using net_calculator_tester;
namespace tester
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test(Description = "Prova Add")]
        [TestCase(15.9f, 18.98f)]
        public void AddTest(float a, float b)
        {
            Assert.That(Calculator.Add(a, b), Is.EqualTo(a + b));
        }

        [Test(Description = "Prova Subtract")]
        [TestCase(15.9f, 18.98f)]
        public void SubtractTest(float a, float b)
        {
            Assert.That(Calculator.Subtract(a, b), Is.EqualTo(a - b));
        }

        [Test(Description = "Prova Multiply")]
        [TestCase(15.9f, 18.98f)]
        public void MultiplyTest(float a, float b)
        {
            Assert.That(Calculator.Multiply(a, b), Is.EqualTo(a * b));
        }

        [Test(Description = "Prova Divide")]
        [TestCase(15.9f, 18.98f)]
        [TestCase(15.9f, 0f)]
        public void DivideTest(float a, float b)
        {
            if(b != 0)
                Assert.That(Calculator.Divide(a, b), Is.EqualTo(a / b));
            else
                Assert.That(Calculator.Divide(a, b), Is.EqualTo(float.NaN));
        }
    }
}