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
        public void KørselsFradagVed20KmTest()
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
            Assert.AreEqual(result, 0.5694);
        }
        [Test]
        public void KørselsFradagVed100KmTest()
        {
            //Arange
            double kms = 100;

            BefordringClass befordring = new BefordringClass(kms);

            //Act
            double result = befordring.ReturnMath();


            // Assert
            Assert.AreEqual(result, 43.2744);
        }
        [Test]
        public void KørselsFradagVed120KmTest()
        {
            //Arange
            double kms = 120;

            BefordringClass befordring = new BefordringClass(kms);

            //Act
            double result = befordring.ReturnMath();


            // Assert
            Assert.AreEqual(result, 54.6624);
        }

        [Test]
        public void KørselsFradagVed200KmTest()
        {
            //Arange
            double kms = 200;

            BefordringClass befordring = new BefordringClass(kms);

            //Act
            double result = befordring.ReturnMath();


            // Assert
            Assert.AreEqual(result, 77.5424);
        }




        //OLD

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
            Assert.AreEqual(result2, 165.8064);
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
            Assert.AreEqual(result2, 829.03199999999993);
        }
    }
}