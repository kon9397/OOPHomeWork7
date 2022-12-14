namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();

            myClass.change = "not changed";
            myStruct.change = "not changed";

            ClassTaker(myClass);
            StructTaker(myStruct);

            Console.WriteLine(myClass.change); // Значение изменено, так как метод ClassTaker принимает экземпляр, которые являются ссылочным типом
            Console.WriteLine(myStruct.change); // Значение не изменено, так как структура является значимым типом, как int, string
        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "changed";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "changed";
        }
    }
}