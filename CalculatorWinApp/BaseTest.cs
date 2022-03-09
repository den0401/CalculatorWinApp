using Aquality.WinAppDriver.Applications;
using NUnit.Framework;

namespace CalculatorWinApp
{
    [TestFixture]
    public class BaseTest
    {
        [OneTimeSetUp]
        public void BeforeAllTests()
        {
            AqualityServices.WinAppDriverLauncher.StartWinAppDriverIfRequired();
        }

        [SetUp]
        public void BeforeEachTest()
        {
            if (AqualityServices.Application.IsStarted)
                AqualityServices.Application.Quit();
        }

        [TearDown]
        public void AfterEachTest()
        {
            AqualityServices.Application.Quit();
        }

        [OneTimeTearDown]
        public void AfterAllTests()
        {
            AqualityServices.WinAppDriverLauncher.TryToStopWinAppDriver();
        }
    }
}