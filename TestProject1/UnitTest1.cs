namespace TestProject1;

[TestFixture]
[Category("Integration")]
public class Tests  : TestBase
{
    [SetUp]
    public void Setup()
    {
        SetupDbContext();
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}