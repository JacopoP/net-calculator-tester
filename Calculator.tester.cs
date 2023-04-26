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

        [Test(Description = "Prova Exponential")]
        [TestCase(5, 10)]
        [TestCase(-5, 10)]
        [TestCase(5, -10)]
        [TestCase(5, 0)]
        [TestCase(0, 10)]
        [TestCase(0, 0)]
        public void ExponentialTest(int a, int b)
        {
            if (b == 0)
                Assert.IsTrue(Calculator.Exponential(a,b) == 1);
            else if (a == 0)
                Assert.IsTrue(Calculator.Exponential(a, b) == 0);
            else if (b > 0)
            {
                double result = 1;
                for(int i = 0; i < b; i++)
                    result *= a;
                Assert.IsTrue(Calculator.Exponential(a, b) == result);
            }
            else if (b < 0)
            {
                double result = 1;
                for (int i = 0; i < -b; i++)
                    result /= a;
                Assert.IsTrue(Calculator.Exponential(a, b) == result);
            }
        }       
    }
}