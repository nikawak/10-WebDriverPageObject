
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace lab9_WebDriver;


public class MyTest : TestsClass
{
    protected override string? Url => "https://5element.by";

    private string product = "Samsung Galaxy M32";

    [Test]
    public void Element5SiteTest_9()
    {
        Thread.Sleep(5000);
        Assert.Fail();
        var authorization = new Authorization(workspace);
        authorization.Authorize();
        
        findElement("//a[@class='h-drop h-user']").Click();
        findElement("//input[@name='login']").SendKeys("+375298822499");
        findElement("//input[@type='password']").SendKeys("qwerty12345");
        Thread.Sleep(1000);
        findElement("//button[@class='btn btn--lg btn--block']//span[text()='Войти']").Click();
        Thread.Sleep(10000);

        Thread.Sleep(1000);
        var pathLike = "//div[@class='n-item__icon ic-favorite']//span";
        int expected;
        if(findElement(pathLike) == null)
        {
            expected = 1;
        }
        else
        {
            expected = 1 + int.Parse(findElement(pathLike).Text);
        }
        

        findElement("//a[@class='nav-item h-discounts']").Click();
        findElement("//img[@title='Скидки']").Click();
        findElement("//div[@data-product_id='763365']//div[@class='c-part'][3]//div[@class='c-actions']//span").Click();
        Thread.Sleep(1000);
        
        var actual = int.Parse(findElement(pathLike).Text);
        Assert.AreEqual(actual, expected);

    }

}