using System;
using System.Collections.Generic;

namespace  TutorialPerulangan
{
   class Program
   {
       static void Main(string[] args)
       {
           Console.WriteLine("===Sistem Kasir Toko Sembako===\n");
           
           string[] daftarBarang = {"Beras 5kg", "Minyak Goreng 2L", "Gula Pasir 1kg", "Mie Instan (5 pcs)"};
           
           Console.WriteLine("Daftar Barang Belanjaan Anda : ");
           int nomor = 1;
           foreach (string barang in daftarBarang)
           {
               Console.WriteLine($"{nomor}. {barang}");
               nomor++;
           }
           Console.WriteLine("-------------------------------");
           
           int[] hargaBarang = {75000, 36000, 15000, 15000};
           int totalBelanja = 0;
           
           for (int i = 0; i < hargaBarang.Length; i++)
           {
               totalBelanja += hargaBarang[i];
           }
           Console.WriteLine($"Total Belanja Awal : Rp {totalBelanja}");
           
           int uangDibayar = 150000;
           int sisaSaranaKembalian = uangDibayar - totalBelanja;
           
           Console.WriteLine($"Uang Tunai Pembeli : Rp {uangDibayar:N0}");
           Console.WriteLine($"Kembalian          : Rp {sisaSaranaKembalian:N0}\n");
           
           Console.WriteLine("Mesin Mengeluarkan pecahan kembalian Rp 50.000");
           int pecahan = 50000;
           
           do
           {
               if (sisaSaranaKembalian >= pecahan)
               {
                   Console.WriteLine($"- Mengluarkan 1 Lembar Rp {pecahan:N0}");
                   sisaSaranaKembalian -= pecahan;
               }
               else
               {
                   break;
               }
           } while (sisaSaranaKembalian >= pecahan);
           
           if (sisaSaranaKembalian > 0)
           {
               Console.WriteLine($"- Sisa Kembalian receh : Rp {sisaSaranaKembalian:N0}");
           }
           
           Console.WriteLine("\n==================================");
           Console.ReadLine();
       }
   }
}
