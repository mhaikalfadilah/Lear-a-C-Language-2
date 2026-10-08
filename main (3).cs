using System;

class percabangan
{
   public static void Main (string[] args)
   {
        Console.WriteLine("===Sistem Evaluasi Mahasiswa===");
        
        string nama = "Budi";
        int nilai = 85;
        int jurusan = 2;
        
        Console.WriteLine($"Nama : {nama}");
        Console.WriteLine($"Nilai: {nilai}");
        
        string predikat;
        
        if (nilai >= 90)
        {
            predikat = "sangat memuaskan (A)";
        }
        else if (nilai >= 80)
        {
            predikat = "memuaskan (B)";
        }
        else if (nilai >= 70)
        {
            predikat = "cukup (c)";
        }
        else
        {
            predikat = "kurang (D)";
        }
        Console.WriteLine($"predikat kelulusan : {predikat}");
        
        string nama_jurusan;
        
        switch (jurusan)
        {
            case 1:
                nama_jurusan = "Teknik Informatika";
                break;
            case 2:
                nama_jurusan = "Sistem Informasi";
                break;
            case 3:
                nama_jurusan = "Desain Komunikasi Visual";
                break;
            default:
                nama_jurusan = "Jurusan Tidak diketahui";
                break;
        }
        Console.WriteLine($"Jurusan = {nama_jurusan}");
        
        string status_kelulusan = (nilai >= 75) ? "LULUS" : "Tidak Lulus";
        
        Console.WriteLine($"Status Mahasiswa : {status_kelulusan}");
        Console.WriteLine("======================================");
        
        Console.ReadLine();
        
   } 
}
