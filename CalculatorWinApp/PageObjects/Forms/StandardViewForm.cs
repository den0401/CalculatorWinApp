using Aquality.WinAppDriver.Elements.Interfaces;
using Aquality.WinAppDriver.Forms;
using OpenQA.Selenium;

namespace CalculatorWinApp.PageObjects.Forms
{
    public class StandardViewForm : Form
    {
        public IButton OneButton => ElementFactory.GetButton(By.Name("1"), "1");

        public IButton TwoButton => ElementFactory.GetButton(By.Name("2"), "2");

        public IButton NineButton => ElementFactory.GetButton(By.Name("9"), "9");

        public IButton PlusButton => ElementFactory.GetButton(By.XPath("//*[@AutomationId = '93']"), "+");

        public IButton EqualButton => ElementFactory.GetButton(By.XPath("//*[@AutomationId = '121']"), "=");

        public IButton MemoryAddButton => ElementFactory.GetButton(By.XPath("//*[@AutomationId = '125']"), "M+");

        public IButton MemoryReadButton => ElementFactory.GetButton(By.XPath("//*[@AutomationId = '123']"), "MR");

        public ITextBox Display => ElementFactory.GetTextBox(By.XPath("//*[@AutomationId = '150']"), "Display");

        public StandardViewForm() : base(By.ClassName("CalcFrame"), "Calculator")
        {
        }

        public string GetDisplayValue()
        {
            return Display.Value.Trim();
        }
    }
}