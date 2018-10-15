namespace CodedUITestProject4
{
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;


    public partial class UIMap
    {

        /// <summary>
        /// SimpleAppTest - Use 'SimpleAppTestParams' to pass parameters into this method.
        /// </summary>
        public UIMap()
        {
            this.UIMainWindowWindow.UIStartButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "buttonA";
        }

        public void ModifiedSimpleAppTest()
        {
            #region Variable Declarations
            WpfButton uIStartButton = this.UIMainWindowWindow.UIStartButton;
            WpfCheckBox uICheckBoxCheckBox = this.UIMainWindowWindow.UICheckBoxCheckBox;
            #endregion

            // Click 'Start' button
            Mouse.Click(uIStartButton, new Point(36, 7));

            uICheckBoxCheckBox.WaitForControlEnabled();
            // Select 'CheckBox' check box
            uICheckBoxCheckBox.Checked = this.SimpleAppTestParams.UICheckBoxCheckBoxChecked;
        }

        public virtual SimpleAppTestParams SimpleAppTestParams
        {
            get
            {
                if ((this.mSimpleAppTestParams == null))
                {
                    this.mSimpleAppTestParams = new SimpleAppTestParams();
                }
                return this.mSimpleAppTestParams;
            }
        }

        private SimpleAppTestParams mSimpleAppTestParams;

        /// <summary>
        /// SimpleTestMethod - Use 'SimpleTestMethodParams' to pass parameters into this method.
        /// </summary>
        public void Modified1SimpleTestMethod()
        {
            #region Variable Declarations
            WpfButton uIStartButton = this.UIMainWindowWindow.UIStartButton;
            WpfCheckBox uICheckBoxCheckBox = this.UIMainWindowWindow.UICheckBoxCheckBox;
            WinButton uICloseButton = this.UIMainWindowWindow1.UICloseButton;
            #endregion

            // Launch '%USERPROFILE%\Desktop\101604238\Week 9\SimpleWPFApp\SimpleWPFApp\bin\Debug\SimpleWPFApp.exe'
            ApplicationUnderTest uIMainWindowWindow = ApplicationUnderTest.Launch(this.SimpleTestMethodParams.UIMainWindowWindowExePath, this.SimpleTestMethodParams.UIMainWindowWindowAlternateExePath);

            // Click 'Start' button
            Mouse.Click(uIStartButton, new Point(54, 11));

            uICheckBoxCheckBox.WaitForControlEnabled();
            // Select 'CheckBox' check box
            uICheckBoxCheckBox.Checked = this.SimpleTestMethodParams.UICheckBoxCheckBoxChecked;

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(32, 12));
        }

        public virtual SimpleTestMethodParams SimpleTestMethodParams
        {
            get
            {
                if ((this.mSimpleTestMethodParams == null))
                {
                    this.mSimpleTestMethodParams = new SimpleTestMethodParams();
                }
                return this.mSimpleTestMethodParams;
            }
        }

        private SimpleTestMethodParams mSimpleTestMethodParams;
    }
    /// <summary>
    /// Parameters to be passed into 'SimpleAppTest'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class SimpleAppTestParams
    {

        #region Fields
        /// <summary>
        /// Select 'CheckBox' check box
        /// </summary>
        public bool UICheckBoxCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'SimpleTestMethod'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class SimpleTestMethodParams
    {

        #region Fields
        /// <summary>
        /// Launch '%USERPROFILE%\Desktop\101604238\Week 9\SimpleWPFApp\SimpleWPFApp\bin\Debug\SimpleWPFApp.exe'
        /// </summary>
        public string UIMainWindowWindowExePath = "C:\\Users\\STUDENT\\Desktop\\101604238\\Week 9\\SimpleWPFApp\\SimpleWPFApp\\bin\\Debug\\Sim" +
            "pleWPFApp.exe";

        /// <summary>
        /// Launch '%USERPROFILE%\Desktop\101604238\Week 9\SimpleWPFApp\SimpleWPFApp\bin\Debug\SimpleWPFApp.exe'
        /// </summary>
        public string UIMainWindowWindowAlternateExePath = "%USERPROFILE%\\Desktop\\101604238\\Week 9\\SimpleWPFApp\\SimpleWPFApp\\bin\\Debug\\Simple" +
            "WPFApp.exe";

        /// <summary>
        /// Select 'CheckBox' check box
        /// </summary>
        public bool UICheckBoxCheckBoxChecked = true;
        #endregion
    }
}
