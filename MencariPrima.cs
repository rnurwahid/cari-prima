//15. Mencari bilangan prima berdasarkan suatu rentang bilangan yang diinput oleh user
using System;
using System.Collections.Generic;

class MencariPrima{
    static void Main(){
        Console.WriteLine("###Mencari bilangan prima berdasarkan suatu rentang bilangan###");
        Console.Write("Masukkan batas bawah: ");
        int batasBawah = int.Parse(Console.ReadLine());

        Console.Write("Masukkan batas atas: ");
        int batasAtas = int.Parse(Console.ReadLine());

        List<int> bilanganPrima = BilanganPrima(batasBawah, batasAtas);

        Console.WriteLine($"Bilangan prima antara {batasBawah} dan {batasAtas} adalah:");
        foreach (int prima in bilanganPrima){
            Console.Write(prima + " ");
        }
    }

    static List<int> BilanganPrima(int batasBawah, int batasAtas){
        List<int> bilanganPrima = new List<int>();

        for (int i = batasBawah; i <= batasAtas; i++){
            if (CekPrima(i)){
                bilanganPrima.Add(i);
            }
        }

        return bilanganPrima;
    }

    static bool CekPrima(int angka){
        if (angka <= 1) return false;
        if (angka == 2) return true;
        if (angka % 2 == 0) return false;

        var batas = (int)Math.Sqrt(angka);
        for (int i = 3; i <= batas; i += 2){
            if (angka % i == 0) return false;
        }

        return true;
    }
}