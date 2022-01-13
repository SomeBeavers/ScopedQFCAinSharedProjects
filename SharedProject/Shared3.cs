namespace net6_sharp10_lib
{
    public class Shared3
    {
        private string _name2;
        public string Name { get; set; }

        private void Test()
        {
        int notAccessed = 0;
#if NET6_0
int notAccessed1 = 0;
            var s = new Shared3().Name.ToString();
#else
            int notAccessed2 = 0;
            var s = new Shared3().Name.ToString();
#endif
        }

        public string Name2
        {
            get => _name2;
            set => _name2 = value;
        }

#if NET6_0
private string _name3;
        public string Name3
        {
            get => _name3;
            set => _name3 = value;
        }
#else
        private string _name4;
        public string Name4
        {
            get => _name4;
            set => _name4 = value;
        }
#endif
    }
}