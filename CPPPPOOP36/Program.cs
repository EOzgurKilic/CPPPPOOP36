namespace CPPPPOOP36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class MyClass1 //If a class is static, it can merely have static members and can't have a constructor as well as instances. Static classes can not be inherited.
    {
        //A lil footnote: const keyword qualifies variables as static, there is no need to type static in addition.
        public const int constStaticNo = 1;

        
        public int NonStaticField;
        public static string StaticField;

        public int NonStaticProperty { get; set; }
        public static int StaticProperty { get; set; }

        public void NonStaticMethod() { }
        public static void StaticMethod() {
            //Static methods can be overloaded but not be overridden as overriding is named dynamic polymorphism.
            //In static members, non static members are not useable whereas they can be utilized in non static members.
            //NonStaticField = constStaticNo;
            StaticField = Convert.ToString(constStaticNo);

        //Static members of a base class can be accessible in the derived class. HOWEVER, it is not overrideable!
        }
    }
    class MyClass2: MyClass1 {
        //Static members of a base class can be accessible in the derived class. HOWEVER, it is not overrideable!
        public void RunStaticBaseMethod() 
        {
            StaticMethod();
            StaticField = "Field Updated as \"Enabled\"!";
        }
    }
}
