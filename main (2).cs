using System;

class percabangan
{
   public static void Main (string[] args)
   {
       int hari = 3;
       switch (hari)
       {
           case 1:
                Console.WriteLine("senin");
                break;
            case 2:
                Console.WriteLine("selasa");
                break;
            case 3:
                Console.WriteLine("rabu");
                break;
            default:
                Console.WriteLine("hari tidak valid");
                break;
       }
       
       
   } 
}
