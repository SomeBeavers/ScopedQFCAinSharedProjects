namespace net6_sharp10_lib
{
    public class Shared3
    {
        public string Name { get; set; }

        private void Test()
        {
            var s = new Shared3().Name.ToString();
        }
    }
}