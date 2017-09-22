// <Snippet2>
using System;

public class Example
{
   public static void Main()
   {
      String s = new String('a', 3);
      Console.WriteLine("The initial string: '{0}'", s);
      s = s.Replace('a', 'b').Replace('b', 'c').Replace('c', 'd');
      Console.WriteLine("The final string: '{0}'", s);
   }
}
// The example displays the following output:
//       The initial string: 'aaa'
//       The final string: 'ddd'
// </Snippet2>
