namespace TestProject1;



[TestClass]
public class UnitTest1
{

    public bool CanDrive(int age)
    {
        //edited the function assuming a person cannot be minus years of age
        if (age < 0)
        {
            throw new System.ArgumentOutOfRangeException();
        }
        const int drivingAge = 16;
        return age >= drivingAge;
    }

    [TestMethod]
    [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
    public void TestMethod1()
    {
        CanDrive(int.MinValue);
    }

    [TestMethod]
    [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
    public void TestMethod2()
    {
        CanDrive(int.MinValue + 1);
    }

    [TestMethod]
    [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
    public void TestMethod3()
    {
        CanDrive(-1);
    }

    [TestMethod]
    public void TestMethod4()
    {
        Assert.AreEqual(false, CanDrive(0));
    }

    [TestMethod]
    public void TestMethod5()
    {
        Assert.AreEqual(false, CanDrive(1));
    }

    [TestMethod]
    public void TestMethod6()
    {
        Assert.AreEqual(false, CanDrive(15));
    }

    [TestMethod]
    public void TestMethod7()
    {
        Assert.AreEqual(true, CanDrive(16));
    }

    [TestMethod]
    public void TestMethod8()
    {
        Assert.AreEqual(true, CanDrive(17));
    }

    [TestMethod]
    public void TestMethod9()
    {
        Assert.AreEqual(true, CanDrive(int.MaxValue - 1));
    }

    [TestMethod]
    public void TestMethod10()
    {
        Assert.AreEqual(true, CanDrive(int.MaxValue));
    }


}