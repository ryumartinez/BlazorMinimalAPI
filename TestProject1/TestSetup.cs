namespace TestProject1;

[SetUpFixture]
public class TestSetup
{
    [OneTimeSetUp]
    public async Task OneTimeSetUp()
    {
        await DbTestSetup.SetupDatabase();
    }
}