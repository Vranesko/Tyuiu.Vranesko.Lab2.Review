namespace Tyuiu.Vranesko.Lab2.Review.V7.Lib;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void CheckGetMassFunction()
    {
        var ds = new DataService();
        int start = -5;
        int end = 5;
        double expected1 = 3750.93;
        double expected2 = 1280.70;
        double expected3 = 323.75;
        double expected4 = 46.81;
        double expected5 = -1.14;
        double expected6 = double.NaN;
        double expected7 = 4.82;
        double expected8 = 17.42;
        double expected9 = 162.26;
        double expected10 = 767.28;
        double expected11 = 2499.06;
        var result = ds.GetMassFunction(start, end);
        Assert.AreEqual(expected1, result[0], 0.01);
        Assert.AreEqual(expected2, result[1], 0.01);
        Assert.AreEqual(expected3, result[2], 0.01);
        Assert.AreEqual(expected4, result[3], 0.01);
        Assert.AreEqual(expected5, result[4], 0.01);
        Assert.AreEqual(expected6, result[5]);
        Assert.AreEqual(expected7, result[6], 0.01);
        Assert.AreEqual(expected8, result[7], 0.01);
        Assert.AreEqual(expected9, result[8], 0.01);
        Assert.AreEqual(expected10, result[9], 0.01);
        Assert.AreEqual(expected11, result[10], 0.01);
    }
}
