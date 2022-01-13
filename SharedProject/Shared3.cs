namespace net6_sharp10_lib
{
    public class Shared3
    {
        public string Name { get; set; }

        private void Test()
        {
        int notAccessed = 0;
#if NET6_0

            var s = new Shared3().Name.ToString();
#else
        var s = new Shared3().Name.ToString();
#endif
        }
    }
}