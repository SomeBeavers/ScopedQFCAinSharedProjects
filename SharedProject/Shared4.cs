namespace net6_sharp10_lib
{
    public class Shared4
    {
        public string PublicMethod(InnerClass? innerClass)
        {
            if (innerClass != null && innerClass.Name == "test")
            {
                Console.WriteLine(innerClass.Name);
            }
            throw new NotImplementedException();
        }

        public class InnerClass
        {
            public string Name { get; set; }
        }
    }
}