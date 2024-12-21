public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod()
    {
        // Some code here...
        if (MyProperty >= 10) // Solution: Correct comparison
        {
            // Do something...
        }
    }
}