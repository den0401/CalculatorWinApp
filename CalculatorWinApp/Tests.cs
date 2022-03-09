using NUnit.Framework;
using CalculatorWinApp.PageObjects.Forms;
using CalculatorWinApp.Utils;

namespace CalculatorWinApp
{
    public class Tests : BaseTest
    {
        private const string EXPECTED_RESULT = "1030";

        private StandardViewForm _standardViewForm = new StandardViewForm();
        private ScientificViewForm _scientificViewForm = new ScientificViewForm();

        [Test]
        public void StandardViewTest()
        {
            AppUtils.SwitchToView(_standardViewForm, ConfigUtils.GetConfigProperties("standardView"));
            Assert.IsTrue(_scientificViewForm.DegreesPanel.State.WaitForNotDisplayed(),
                "Scientific view is displayed instead of Standard view");

            _standardViewForm.OneButton.Click();
            _standardViewForm.TwoButton.Click();

            _standardViewForm.PlusButton.Click();

            _standardViewForm.NineButton.MouseActions.DoubleClick();
            _standardViewForm.NineButton.MouseActions.Click();

            _standardViewForm.EqualButton.Click();
            
            _standardViewForm.MemoryAddButton.Click();
            
            _standardViewForm.OneButton.Click();
            _standardViewForm.NineButton.Click();

            _standardViewForm.PlusButton.Click();

            _standardViewForm.MemoryReadButton.Click();

            _standardViewForm.EqualButton.Click();
            Assert.AreEqual(_standardViewForm.GetDisplayValue(), EXPECTED_RESULT,
                "Calculation result is incorrect");
        }

        [Test]
        public void ScientificViewTest()
        {
            AppUtils.SwitchToView(_scientificViewForm, ConfigUtils.GetConfigProperties("scientificView"));
            Assert.IsTrue(_scientificViewForm.DegreesPanel.State.WaitForDisplayed(),
                "Standard view is displayed instead of Scientific view");

            _scientificViewForm.OneButton.Click();
            _scientificViewForm.TwoButton.Click();

            _scientificViewForm.PlusButton.Click();

            _scientificViewForm.NineButton.MouseActions.DoubleClick();
            _scientificViewForm.NineButton.MouseActions.Click();

            _scientificViewForm.EqualButton.Click();

            _scientificViewForm.MemoryAddButton.Click();

            _scientificViewForm.OneButton.Click();
            _scientificViewForm.NineButton.Click();

            _scientificViewForm.PlusButton.Click();

            _scientificViewForm.MemoryReadButton.Click();

            _scientificViewForm.EqualButton.Click();
            Assert.AreEqual(_scientificViewForm.GetDisplayValue(), EXPECTED_RESULT,
                "Calculation result is incorrect");
        }
    }
}