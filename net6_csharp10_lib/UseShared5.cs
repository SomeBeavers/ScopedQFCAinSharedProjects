using net6_sharp10_lib;

namespace net6_csharp10_lib;

public class UseShared5
{
    private void Test()
    {
        var useShared5 = new Shared5();
        useShared5.NewName = "";

        if (useShared5.NewName == String.Empty)
        {
            
        }
    }
}