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
using Keys = OpenQA.Selenium.Keys;

namespace REDDIT_CREATE_POST_TEST
{
    public partial class Form1 : Form
    {
        //2151010419 - Tran Luu Quoc Tuan - 62
        private IWebDriver driver;

        //2151010419 - Tran Luu Quoc Tuan - 62
        private const string siteURL = "https://reddit.com/";

//2151010419 - Tran Luu Quoc Tuan - 62
        private void useProfile()
        {
            var options = new ChromeOptions();
            //C:\\Users\\Admin\\AppData\\Local\\Google\\Chrome\\User Data
            //C:\\Users\\HP\\AppData\\Local\\Google\\Chrome\\User Data\\
            //2151010419 - Tran Luu Quoc Tuan - 62
            options.AddArgument("user-data-dir=C:\\Users\\HP\\AppData\\Local\\Google\\Chrome\\User Data\\");

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
        private void clickCreatePost()
        {
            var createPostButton = driver.FindElement(By.ClassName("_326PJFFRv8chYfOlaEYmGt"));
            createPostButton.Click();

        }

//2151010419 - Tran Luu Quoc Tuan - 62
        private void checkDisablePostButton(int testNum)
        {
            var postButton = driver.FindElement(By.ClassName("_18Bo5Wuo3tMV-RDB8-kh8Z"));

            //2151010419 - Tran Luu Quoc Tuan - 62
            if (postButton.GetAttribute("disabled") == "true")
                listBoxTC.Items.Add("Test Case " + testNum + " passed");
            else
                listBoxTC.Items.Add("Test Case " + testNum + " failed");

        }

//2151010419 - Tran Luu Quoc Tuan - 62
        private void enterSubReddit()
        {
            //2151010419 - Tran Luu Quoc Tuan - 62
            var subredditBox = driver.FindElement(By.ClassName("_1MHSX9NVr4C2QxH2dMcg4M"));

            //2151010419 - Tran Luu Quoc Tuan - 62
            subredditBox.SendKeys("r/softest");
            subredditBox.SendKeys(Keys.Return);
        }

//2151010419 - Tran Luu Quoc Tuan - 62
        private void enterTitle()
        {
            var titleBox = driver.FindElement(By.ClassName("PqYQ3WC15KaceZuKcFI02"));
            titleBox.SendKeys("Sofw@t3St P()st");
        }

//2151010419 - Tran Luu Quoc Tuan - 62
        private void enterContent()
        {
            var contentBox = driver.FindElement(By.ClassName("notranslate"));
            contentBox.SendKeys("Nội dung test 123");

        }

//2151010419 - Tran Luu Quoc Tuan - 62
        private void enterIncorrectPicType()
        {
            var imageButton = driver.FindElement(By.ClassName("_2keaDnXIlu9Yq2y-cC8zgu"));


            imageButton.SendKeys("D:\\OU 3RD YEAR\\SOFTWARE TESTING\\BTL_SOFTEST\\Img\\4022436.eps");
            

        }

//2151010419 - Tran Luu Quoc Tuan - 62
        private void enterIncorrectPicSize()
        {
            var imageButton = driver.FindElement(By.ClassName("_2keaDnXIlu9Yq2y-cC8zgu"));
            imageButton.SendKeys("D:\\OU 3RD YEAR\\SOFTWARE TESTING\\BTL_SOFTEST\\Img\\Sample-png-image-30mb.png");


        }

//2151010419 - Tran Luu Quoc Tuan - 62
        private void enterCorrectPicType()
        {
            var imageButton = driver.FindElement(By.ClassName("_2keaDnXIlu9Yq2y-cC8zgu"));
            imageButton.SendKeys("D:\\OU 3RD YEAR\\SOFTWARE TESTING\\BTL_SOFTEST\\Img\\TRIANGLE.png");


        }

//2151010419 - Tran Luu Quoc Tuan - 62
        private void checkIncorrectTypeMessage(int testNum)
        {
            var message = driver.FindElement(By.ClassName("_7JH6kQpO-bx66b9ajIZrz"));

            //2151010419 - Tran Luu Quoc Tuan - 62
            if (message.Text == "Sorry, we accept only images (.png, .jpeg, .gif) and videos (.mp4, .mov)")
                listBoxTC.Items.Add("Test Case " + testNum + " passed");
            else
                listBoxTC.Items.Add("Test Case " + testNum + " failed");

        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        private void checkIncorrectPicSizeMessage(int testNum)
        {
            var message = driver.FindElement(By.ClassName("_7JH6kQpO-bx66b9ajIZrz"));

            //2151010419 - Tran Luu Quoc Tuan - 62
            if (message.Text == "Image size must be less than 20MB")
                listBoxTC.Items.Add("Test Case " + testNum + " passed");
            else
                listBoxTC.Items.Add("Test Case " + testNum + " failed");
        }

//2151010419 - Tran Luu Quoc Tuan - 62
        private void checkIncorrectVidSizeMessage(int testNum)
        {
            var message = driver.FindElement(By.ClassName("_7JH6kQpO-bx66b9ajIZrz"));

            //2151010419 - Tran Luu Quoc Tuan - 62
            if (message.Text == "Video size must be less than 1.0GB")
                listBoxTC.Items.Add("Test Case " + testNum + " passed");
            else
                listBoxTC.Items.Add("Test Case " + testNum + " failed");
        }

//2151010419 - Tran Luu Quoc Tuan - 62
        private void checkIncorrectVidLengthMessage(int testNum)
        {
            var message = driver.FindElement(By.ClassName("_7JH6kQpO-bx66b9ajIZrz"));

            //2151010419 - Tran Luu Quoc Tuan - 62
            if (message.Text == "Video is too long. Maximum video length is 15 minutes.")
                listBoxTC.Items.Add("Test Case " + testNum + " passed");
            else
                listBoxTC.Items.Add("Test Case " + testNum + " failed");

        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        private void enterIncorrectVidType()
        {
            var vidButton = driver.FindElement(By.ClassName("_2keaDnXIlu9Yq2y-cC8zgu"));
            vidButton.SendKeys("D:\\OU 3RD YEAR\\SOFTWARE TESTING\\BTL_SOFTEST\\Vid\\sample_960x400_ocean_with_audio.flv");
        }

//2151010419 - Tran Luu Quoc Tuan - 62
        private void enterCorrectVidType()
        {
            var vidButton = driver.FindElement(By.ClassName("_2keaDnXIlu9Yq2y-cC8zgu"));
            vidButton.SendKeys("D:\\OU 3RD YEAR\\SOFTWARE TESTING\\BTL_SOFTEST\\Vid\\Chloe Chua plays finale from Bruch.mp4");
        }

//2151010419 - Tran Luu Quoc Tuan - 62
        private void enterIncorrectVidSize()
        {
            var vidButton = driver.FindElement(By.ClassName("_2keaDnXIlu9Yq2y-cC8zgu"));
            vidButton.SendKeys("D:\\HELLVEN\\HELLVEN-ETOUR.m4v");
        }

//2151010419 - Tran Luu Quoc Tuan - 62
        private void enterIncorrectVidLength()
        {
            var vidButton = driver.FindElement(By.ClassName("_2keaDnXIlu9Yq2y-cC8zgu"));
            vidButton.SendKeys("D:\\OU 3RD YEAR\\SOFTWARE TESTING\\BTL_SOFTEST\\Vid\\for calm nights (432Hz playlist).mp4");
        }

//2151010419 - Tran Luu Quoc Tuan - 62
        private void checkPostPossible(int testNum)
        {
            var postButton = driver.FindElement(By.ClassName("_10BQ7pjWbeYP63SAPNS8Ts"));

            //2151010419 - Tran Luu Quoc Tuan - 62
            listBoxTC.Items.Add(postButton.GetCssValue("background-color"));

            //2151010419 - Tran Luu Quoc Tuan - 62
            if (postButton.GetCssValue("background-color") == "rgba(50, 147, 219, 0)")
            {
                listBoxTC.Items.Add("Test Case " + testNum + " passed");
            }
            else
                listBoxTC.Items.Add("Test Case " + testNum + " failed");

        }

        //2151010419 - Tran Luu Quoc Tuan - 62

        //2151010419 - Tran Luu Quoc Tuan - 62
        public Form1()
        {
            InitializeComponent();
            useProfile();
        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        //Test Case 1 
        private void buttonTC1_Click(object sender, EventArgs e)
        {
            navigate();
            clickCreatePost();
            checkDisablePostButton(1);
        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        //Test Case 2 
        private void buttonTC2_Click(object sender, EventArgs e)
        {
            navigate();
            clickCreatePost();
            Thread.Sleep(1000);
            enterSubReddit();
            checkDisablePostButton(2);
        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        //Test Case 3 
        private void buttonTC3_Click(object sender, EventArgs e)
        {
            navigate();
            clickCreatePost();
            Thread.Sleep(1000);
            enterSubReddit();
            enterTitle();
            enterContent();
            enterIncorrectPicType();
            Thread.Sleep(1000);
            checkIncorrectTypeMessage(3);
        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        //Test Case 4 
        private void buttonTC4_Click(object sender, EventArgs e)
        {
            navigate();
            clickCreatePost();
            Thread.Sleep(1000);
            enterSubReddit();
            enterTitle();
            enterContent();
            enterCorrectPicType();
            enterIncorrectVidType();
            Thread.Sleep(1000);
            checkIncorrectTypeMessage(4);
        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        //Test Case 5 
        private void buttonTC5_Click(object sender, EventArgs e)
        {
            navigate();
            clickCreatePost();
            Thread.Sleep(1000);
            enterSubReddit();
            enterTitle();
            enterContent();
            enterIncorrectVidType();
            Thread.Sleep(1000);
            checkIncorrectTypeMessage(5);
        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        //Test Case 6 
        private void buttonTC6_Click(object sender, EventArgs e)
        {
            navigate();
            clickCreatePost();
            Thread.Sleep(1000);
            enterSubReddit();
            enterTitle();
            enterContent();
            enterIncorrectPicSize();
            enterCorrectVidType();
            Thread.Sleep(1000);
            checkIncorrectPicSizeMessage(6);
        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        //Test Case 7 
        private void buttonTC7_Click(object sender, EventArgs e)
        {
            navigate();
            clickCreatePost();
            Thread.Sleep(1000);
            enterSubReddit();
            enterTitle();
            enterContent();
            enterIncorrectPicSize();
            Thread.Sleep(1000);
            checkIncorrectPicSizeMessage(7);
        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        //Test Case 8
        private void buttonTC8_Click(object sender, EventArgs e)
        {
            navigate();
            clickCreatePost();
            Thread.Sleep(1000);
            enterSubReddit();
            enterTitle();
            enterContent();
            enterCorrectPicType();
            enterIncorrectVidSize();
            Thread.Sleep(1500);
            checkIncorrectVidSizeMessage(8);

        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        //Test Case 9
        private void buttonTC9_Click(object sender, EventArgs e)
        {
            navigate();
            clickCreatePost();
            Thread.Sleep(1000);
            enterSubReddit();
            enterTitle();
            enterContent();
            enterIncorrectVidSize();
            Thread.Sleep(1500);
            checkIncorrectVidSizeMessage(9);
        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        //Test Case 10
        private void buttonTC10_Click(object sender, EventArgs e)
        {
            navigate();
            clickCreatePost();
            Thread.Sleep(1000);
            enterSubReddit();
            enterTitle();
            enterContent();
            enterIncorrectVidLength();
            enterCorrectPicType();
            Thread.Sleep(1500);
            checkIncorrectVidLengthMessage(10);
        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        //Test Case 11
        private void buttonTC11_Click(object sender, EventArgs e)
        {
            navigate();
            clickCreatePost();
            Thread.Sleep(1000);
            enterSubReddit();
            enterTitle();
            enterContent();
            enterIncorrectVidLength();
            Thread.Sleep(1500);
            checkIncorrectVidLengthMessage(11);
        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        //Test Case 12
        private void buttonTC12_Click(object sender, EventArgs e)
        {
            navigate();
            clickCreatePost();
            Thread.Sleep(1000);
            enterSubReddit();
            enterTitle();
            enterContent();
            enterCorrectPicType();
            enterCorrectVidType();
            checkPostPossible(12);
        }

        //2151010419 - Tran Luu Quoc Tuan - 62
        //Test Case 13
        private void buttonTC13_Click(object sender, EventArgs e)
        {
            navigate();
            clickCreatePost();
            Thread.Sleep(1000);
            enterSubReddit();
            enterTitle();
            enterContent();
            checkPostPossible(13);
        }
    }

}
