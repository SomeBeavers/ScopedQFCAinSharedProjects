namespace LinkedFiles
{
    public class LinkedFile1
    {
        public LinkedFile1(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

#if NET6_0
        private void Test()
        {
            int t = 1;
        }
#else
        private void Test()
        {
            int t = 1;
        }
#endif
    }
}