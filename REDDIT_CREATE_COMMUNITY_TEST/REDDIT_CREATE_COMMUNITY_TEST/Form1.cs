using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;
using Keys = OpenQA.Selenium.Keys;

namespace REDDIT_CREATE_COMMUNITY_TEST
{
    public partial class Form1 : Form
    {
        //2151010419 - Tran Luu Quoc Tuan - 62
        private IWebDriver driver;

        //2151010419 - Tran Luu Quoc Tuan - 62
        private string takenName = "3DMA";

        //2151010419 - Tran Luu Quoc Tuan - 62
        private const string siteURL = "https://reddit.com/";

        //2151010419 - Tran Luu Quoc Tuan - 62
        private void useProfile()
        {
            var options = new ChromeOptions();
            //C:\\Users\\Admin\\AppData\\Local\\Google\\Chrome\\User Data
            //C:\\Users\\HP\\AppData\\Local\\Google\\Chrome\\User Data\\
            //2151010419 - Tran Luu Quoc Tuan - 62
            options.AddArgument("user-data-dir=C:\\Users\\Admin\\AppData\\Local\\Google\\Chrome\\User Data");

            //2151010419 - Tran Luu Quoc Tuan - 62
            options.AddArgument("profile-directory=Profile 1");

            //2151010419 - Tran Luu Quoc Tuan - 62
            driver = new ChromeDriver(options);
        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        private void navigate()
        {
            driver.Navigate().GoToUrl(siteURL);

        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        private void clickCreateCommunity()
        {
            Thread.Sleep(1500);
            var createCommButton = driver.FindElement(By.Id("create-community-button"));
            createCommButton.Click();

        }
        
        //2151010419 - Tran Luu Quoc Tuan - 62
        private void clickCreate()
        {
            driver.FindElement(By.XPath("//*[@id=\"SHORTCUT_FOCUSABLE_DIV\"]/div[4]/div/div/div/div/div/div/div[4]/button[2]"))
                .Click();

        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        private void checkNameNotEntered(int testNum)
        {
            Thread.Sleep(1000);

            //2151010419 - Tran Luu Quoc Tuan - 62
            var redMessage = driver.FindElement(By.ClassName("_3h_9YwxjuOr77VhScPrjCI"));

            //2151010419 - Tran Luu Quoc Tuan - 62
            if (redMessage.Text == "A community name is required")
                listBoxTC.Items.Add("Test Case " + testNum + " passed");
            else
                listBoxTC.Items.Add("Test Case " + testNum + " failed");

        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        private void checkTakenName(int testNum)
        {
            Thread.Sleep(1000);

            var redMessage = driver.FindElement(By.ClassName("_3h_9YwxjuOr77VhScPrjCI"));

            //2151010419 - Tran Luu Quoc Tuan - 62
            if (redMessage.Text == "Sorry, " + takenName + " is taken. Try another.")
                listBoxTC.Items.Add("Test Case " + testNum + " passed");
            else
                listBoxTC.Items.Add("Test Case " + testNum + " failed");

        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        private void checkSubredditAllowed(int testNum)
        {
            Thread.Sleep(1000);

            //2151010419 - Tran Luu Quoc Tuan - 62
            try
            {
                var redMessage = driver.FindElement(By.ClassName("_3h_9YwxjuOr77VhScPrjCI"));

                if (redMessage.Text == "Phew, looks like you've been creating a lot of communities! " +
                    "You'll have to hold off for 30 minutes before you can create another.")
                    listBoxTC.Items.Add("Test Case " + testNum + " passed");
                else
                    listBoxTC.Items.Add("Test Case " + testNum + " failed");
            }
            catch(NoSuchElementException ex)
            {
                //2151010419 - Tran Luu Quoc Tuan - 62
                var welcomeWindow = driver.FindElement(By.ClassName("_1uaasV6RaxBfRyVgQJdiKs"));

                if (welcomeWindow.Text == "Welcome to your new community, r/" + textBoxUName + 
                    "! Set the tone for your community and welcome new members with a post.")
                    listBoxTC.Items.Add("Test Case " + testNum + "passed");
                else
                    listBoxTC.Items.Add("Test Case " + testNum + "failed");

            }
        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        private void enterTakenName()
        {
            //2151010419 - Tran Luu Quoc Tuan - 62
            var nameBox = driver.FindElement(By.ClassName("_3CWuMoFPzdbJCxYJVmEw00"));

            //2151010419 - Tran Luu Quoc Tuan - 62
            nameBox.SendKeys(takenName);
        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        private void enterUniqueName()
        {
            //2151010419 - Tran Luu Quoc Tuan - 62
            var nameBox = driver.FindElement(By.ClassName("_3CWuMoFPzdbJCxYJVmEw00"));

            //2151010419 - Tran Luu Quoc Tuan - 62
            nameBox.SendKeys(textBoxUName.Text);
        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        public Form1()
        {
            InitializeComponent();
            useProfile();
        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        private void buttonTC1_Click(object sender, EventArgs e)
        {
            navigate();
            clickCreateCommunity();
            clickCreate();
            checkNameNotEntered(1);
        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        private void buttonTC2_Click(object sender, EventArgs e)
        {
            navigate();
            clickCreateCommunity();
            enterTakenName();
            clickCreate();
            checkTakenName(2);
        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        private void buttonTC3_Click(object sender, EventArgs e)
        {
            navigate();
            clickCreateCommunity();
            enterUniqueName();
            clickCreate();
            checkSubredditAllowed(3);
        }
    }
}
