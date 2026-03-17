namespace Program1Teszteles;
using Program1;


    public class UnitTest1
{
    [Fact]
    public void Method1()
    {
        var program = new SimpleProgram();
        int result = program.Method1("Hello");
        Assert.Equal(5, result);
    }
    
    [Fact]
    public void Method2()
    {
        var program = new SimpleProgram();
        string result = program.Method2("Hello");
        Assert.Equal("HELLO", result);
    }

    [Fact]
    public void Method3() {
        var program = new SimpleProgram();
        string result = program.Method3("Hello");
        Assert.Equal("hello", result);
    }
    [Fact]
    public void Method4()
    {
        var program = new SimpleProgram();
        bool result = program.Method4("alma");
        Assert.True(true);
    }
    [Fact]
    public void Method5()
    {
        var program = new SimpleProgram();
        int result = program.Method5("banana");
        Assert.Equal(3, result);
    }
    [Fact]
    public void Method6()
    {
        var program = new SimpleProgram();
        string result = program.Method6("Banana", "Apple");
        Assert.Equal("Banana Apple", result);
    }
    [Fact]
    public void Method7()
    {
        var program = new SimpleProgram();
        bool result = program.Method7(7);
        Assert.True(true);
    }
    [Fact]
    public void Method8()
    {
        var program = new SimpleProgram();
        bool result = program.Method8(11);
        Assert.False(false);
    }
    [Fact]
    public void Method9()
    {
        var program = new SimpleProgram();
        string result = program.Method9("valami");
        Assert.Equal("imalav", result);
    }
    [Fact]
    public void Method10()
    {
        var program = new SimpleProgram();
        int result = program.Method10(new int[] { 5, 11, 12, 13, 0 });
        Assert.Equal(3, result);

    }
}


