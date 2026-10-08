using System;

class percabangan
{
   public static void Main (string[] args)
   {
       int umur = 19;
       string status = (umur >= 17) ? "Dewasa" : "Anak - Anak";
       
       Console.WriteLine(status);
   } 
}
