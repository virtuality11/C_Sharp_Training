namespace Collection
{
    public class Generics
    {
        static public T Add<T>(T a, T b) where T : IConvertible
        {

            if (a is int)
            {
                var num1 = Convert.ToInt64(a);
                var num2 = Convert.ToInt64(b);
                num1 += num2; 
                return (T)Convert.ChangeType(num1, typeof(T));
            }
            else if (a is long)
            {
                var num1 = Convert.ToInt64(a);
                var num2 = Convert.ToInt64(b);
                num1 += num2; 
                return (T)Convert.ChangeType(num1, typeof(T));
            }
            else if (a is double)
            {
                var num1 = Convert.ToDouble(a);
                var num2 = Convert.ToDouble(b);
                num1 += num2; 
                return (T)Convert.ChangeType(num1, typeof(T));
            }

            else if (a is byte)
            {
                var num1 = Convert.ToByte(a);
                var num2 = Convert.ToByte(b);
                num1 += num2; 
                return (T)Convert.ChangeType(num1, typeof(T));
            }

            else if (a is short)
            {
                var num1 = Convert.ToInt16(a);
                var num2 = Convert.ToInt16(b);
                num1 += num2; 
                return (T)Convert.ChangeType(num1, typeof(T));
            }

            else if (a is string)
            {
                var num1 = Convert.ToString(a);
                var num2 = Convert.ToString(b);
                num1 += num2; 
                return (T)Convert.ChangeType(num1, typeof(T));
            }
            else if (a is decimal)
            {
                var num1 = Convert.ToDecimal(a);
                var num2 = Convert.ToDecimal(b);
                num1 += num2; 
                return (T)Convert.ChangeType(num1, typeof(T));

            }

            //Type t = typeof(T);
            //switch (t.ToString())
            //{
            //    case "System.Int32": Console.WriteLine(Convert.ToInt32(a) + Convert.ToInt32(b)); break;
            //    case "System.Char": Console.WriteLine(Convert.ToChar(a) + Convert.ToChar(b)); break;
            //    case "System.Int16": Console.WriteLine(Convert.ToInt16(a) + Convert.ToInt16(b)); break;
            //    case "System.Int64": Console.WriteLine(Convert.ToInt64(a) + Convert.ToInt64(b)); break;
            //    case "System.Double": Console.WriteLine(Convert.ToDouble(a) + Convert.ToDouble(b)); break;
            //    case "System.String": Console.WriteLine(Convert.ToString(a) + Convert.ToString(b)); break;
            //}

            else 
            return a;

        }

        static void Main(string[] args)
        {
            var result = Generics.Add<string>("ayush", " juyal");
            Console.WriteLine(result);
        }
    }
}