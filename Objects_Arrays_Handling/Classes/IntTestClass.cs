using Objects_Arrays_Handling.Interfaces;

namespace Objects_Arrays_Handling.Classes;

public class IntTestClass : IPrintableInteger
{
    public int TestVariable { get; set; }

    //public int IntegerValue => TestVariable;
    
    public int IntegerValue
    {
        get
        {
            return TestVariable;
        }
    }
}