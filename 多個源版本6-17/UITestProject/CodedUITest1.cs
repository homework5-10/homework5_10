using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace UITestProject
{
    /// <summary>
    /// CodedUITest1 的摘要说明
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }


        #region 附加测试特性

        // 编写测试时，可以使用以下附加特性:

        ////运行每项测试之前使用 TestInitialize 运行代码 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // 若要为此测试生成代码，请从快捷菜单中选择“为编码的 UI 测试生成代码”，然后选择菜单项之一。
        //    // 有关生成的代码的详细信息，请参见 http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        ////运行每项测试之后使用 TestCleanup 运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // 若要为此测试生成代码，请从快捷菜单中选择“为编码的 UI 测试生成代码”，然后选择菜单项之一。
        //    // 有关生成的代码的详细信息，请参见 http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        #endregion

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
        [TestInitialize]
        public void ReSetUISata()
        {

            this.UIMap.ReSetUI();

        }


        [TestMethod]
        public void TestNoCondtionalAndChangePage()
        {
            UIMap UITest = new UIMap();
            UITest.TestNoCondtional();
            this.UIMap.AssertAssertNoCondational();

        }

        [TestMethod]
        public void TestCondtionalAndChangePage()
        {
            UIMap UITest = new UIMap();
            this.UIMap.TestCondtionalByFMC();
            this.UIMap.AssertTestCondtionalByFMC();


        }
        [TestMethod]
        public void TestReSetButton()
        {
            UIMap UITest = new UIMap();
            this.UIMap.TestReSetButton();
            this.UIMap.AssertReSetButton();
        }


    }
}
