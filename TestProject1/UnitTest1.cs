using NUnit.Framework;
using Befordring;


namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestFor20KM()
        {
            //Arange
            double kms = 20;

            BefordringClass befordring = new BefordringClass(kms);

            //Act
            double result = befordring.ReturnMath();


            // Assert
            Assert.AreEqual(result, 0);
        }
        [Test]
        public void KørselsFradagVed25KmTest()
        {
            //Arange
            double kms = 25;

            BefordringClass befordring = new BefordringClass(kms);

            //Act
            double result = befordring.ReturnMath();


            // Assert
            Assert.AreEqual(result, 6.5);
        }
        [Test]
        public void TestFor100KM()
        {
            //Arange
            double kms = 100;

            BefordringClass befordring = new BefordringClass(kms);

            //Act
            double result = befordring.ReturnMath();


            // Assert
            Assert.AreEqual(result, 26);
        }
        [Test]
        public void TestFor120KM()
        {
            //Arange
            double kms = 120;

            BefordringClass befordring = new BefordringClass(kms);

            //Act
            double result = befordring.ReturnMath();


            // Assert
            Assert.AreEqual(result, 31.2);
        }

        [Test]
        public void TestFor200KM()
        {
            //Arange
            double kms = 200;

            BefordringClass befordring = new BefordringClass(kms);

            //Act
            double result = befordring.ReturnMath();


            // Assert
            Assert.AreEqual(result, 75.296);
        }




        //OLD

        [Test]
        public void TestingOfNormalValue()
        {
            //Arange
            double kms = 124;

            BefordringClass befordring = new BefordringClass(kms);

            //Act
            double result = befordring.ReturnMath();


            // Assert
            Assert.AreEqual(result, 53.5600);
        }

        [Test]
        public void TestingIfBridgeWorks()
        {
            //Arange
            double kms = 124;
            int answer = 1;

            BefordringClass befordring = new BefordringClass(kms);

            //Act
            double result2 = befordring.ReturnQA(answer);

            // Assert
            Assert.AreEqual(result2, 163.56);
        }
        [Test]
        public void TestingForEachDay()
        {
            //Arange
            double kms = 124;
            int answer = 1;
            int day = 5;

            BefordringClass befordring = new BefordringClass(kms);

            //Act
            double result2 = befordring.ReturnQA(answer) * day;

            // Assert
            Assert.AreEqual(result2, 817.8);
        }
    }
}