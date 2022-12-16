using lab9_WebDriver.Pages;


namespace lab9_WebDriver;


public class MyTest : TestsClass
{
    protected override string? Url => "https://5element.by";

    [Test]
    public void Element5SiteTest_1()
    {
        var authorization = new AuthorizationPage(workspace);
        var main = new MainPage(workspace);
        var product = new ProductPage(workspace);

        authorization.Authorize();
       
        int? expected = product.LikeCount == null? 1 : 1 + product.LikeCount;
        

        main.OpenDiscounts();
        main.OpenSales();

        product.Like("763365");
        Thread.Sleep(1000);
        
        var actual = product.LikeCount;
        expected = expected < actual ? expected - 2 : expected;


        Assert.AreEqual(actual, expected);

    }
    [Test]
    public void Element5SiteTest_2()
    {
        var authorization = new AuthorizationPage(workspace);
        var main = new MainPage(workspace);
        var product = new ProductPage(workspace);

        authorization.Authorize();

        int? expected = product.CartCount == null ? 1 : 1 + product.CartCount;


        main.OpenTelevisions();

        product.AddToCart("748474");
        Thread.Sleep(1000);

        var actual = product.CartCount;

        Assert.AreEqual(actual, expected);

    }

}