namespace net6_sharp10_lib
{
    public class Preprocessor
    {
#if NET6_0
        public void Test()
        {
            string s = "";
        }
#else
        public void Test()
        {
            // use var
            int t = 1;

        }
#endif
    }
}