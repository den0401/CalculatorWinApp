using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aquality.WinAppDriver.Elements.Interfaces;
using Aquality.WinAppDriver.Forms;
using OpenQA.Selenium;

namespace CalculatorWinApp.PageObjects.Forms
{
    public class ScientificViewForm : StandardViewForm
    {
        public ILabel DegreesPanel => ElementFactory.GetLabel(By.XPath("//*[@AutomationId = '1079']"), "Degrees panel");

        public ScientificViewForm()
        {
        }
    }
}