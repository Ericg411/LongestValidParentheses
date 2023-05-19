namespace LongestValidParenthesesRepo.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;
    public UnitTest1() 
    {
        _test = new Class1();
    }

    [TestMethod]
    public void TestMethod1()
    {
        string s = "(()";
        int result = _test.LongestValidParentheses(s);
        Assert.AreEqual(2, result);
    }  
    
    [TestMethod]
    public void TestMethod2()
    {
        string s = ")()())";
        int result = _test.LongestValidParentheses(s);
        Assert.AreEqual(4, result);
    } 
    
    [TestMethod]
    public void TestMethod3()
    {
        string s = "";
        int result = _test.LongestValidParentheses(s);
        Assert.AreEqual(0, result);
    }  
    
    [TestMethod]
    public void TestMethod4()
    {
        string s = "())(()((()))((())(()()()()((()()(())()";
        int result = _test.LongestValidParentheses(s);
        Assert.AreEqual(10, result);
    }
}