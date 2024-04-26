using System.Reflection;

namespace ReflectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type mathType = typeof(System.Math);
            
            Type myType = typeof(MyClass);

            MyClass ob = new MyClass();

            Type myType2 = ob.GetType();

            Console.WriteLine("Fields");

            foreach (var f  in myType.GetFields(BindingFlags.DeclaredOnly
            | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
            {
                var str = f.IsPublic ? "pubic" : "priv";
                Console.WriteLine($"{f.Name}  {f.FieldType} {str}");
            }

            Console.WriteLine("Properties");

            foreach (var p in myType.GetProperties())
            {
                Console.WriteLine($"{p.Name}  {p.GetMethod.ReturnParameter.ParameterType}");
                Console.WriteLine($"{p.SetMethod.GetParameters()[0].Name}  {p.SetMethod.GetParameters()[0].ParameterType}");
                
                Console.WriteLine(p.GetGetMethod().Invoke(ob, null));
            }

            Console.WriteLine("Constructors");

            foreach (var c in myType.GetConstructors())
            {
                Console.WriteLine($"{c.Name} {c.GetParameters().Length}");
                //p.GetGetMethod.Invoke(ob, null);
            }

            Console.WriteLine("Methods");

            foreach (var m in myType.GetMethods(BindingFlags.DeclaredOnly
            | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
            {
                Console.WriteLine($"{m.Name} {m.GetParameters().Length} {m.ReturnType}");
                
                if(m.Name == "Method1")
                    m.Invoke(ob, new object[] { 20 });
                if (m.Name == "Method2")
                    Console.WriteLine( m.Invoke(ob,null));

            }

            Console.WriteLine("********************");

            Assembly asm = Assembly.LoadFrom("LinqApp.dll");

            Console.WriteLine(asm.FullName);
            // получаем все типы из сборки MyApp.dll
            Type[] types = asm.GetTypes();
            foreach (Type t in types)
            {
                Console.WriteLine(t.Name);
            }

        }
    }
}
