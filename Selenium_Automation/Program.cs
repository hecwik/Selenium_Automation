

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

IWebDriver driver = new ChromeDriver(@"C:\Users\hewd\Downloads\chromedriver.exe");

driver.Url = @"https://cpm-utv01.sek.se/";