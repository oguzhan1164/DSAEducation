﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace VeriYapılarıUygulamaları
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSetPractice();
            Console.ReadKey();
        }

        private static void HashSetPractice()
        {
            //Hashset
            //Tanımlama
            var sesliHarf = new HashSet<char>()
            {
                'e','ı','i','u','ü','o','ö','b'
            };
            //KoleysiyonYazdir(sesliHarf);
            //Ekleme
            sesliHarf.Add('a');
            //KoleysiyonYazdir(sesliHarf);

            //Listeden çıkarma
            sesliHarf.Remove('b');
            KoleysiyonYazdir(sesliHarf);

            var alfabe = new List<char>();
            for (int i = 97; i < 123; i++)
                alfabe.Add((char)i);

            //alfabe.ForEach(k => Console.WriteLine(k));

            //var hashAlfabe = new HashSet<char>();

            //for(int i =0; i<alfabe.Count; i++)
            //{
            //    hashAlfabe.Add(alfabe[i]);
            //}
            //KoleysiyonYazdir(hashAlfabe);
            KoleysiyonYazdir(alfabe);

            //Türkçe'de kullanılan sesli harfler

            //sesliHarf.ExceptWith(alfabe);
            //KoleysiyonYazdir(sesliHarf);
            //Tüm harfler
            sesliHarf.UnionWith(alfabe);
            KoleysiyonYazdir(sesliHarf);
            //Kesişim
            //sesliHarf.IntersectWith(alfabe);
            //KoleysiyonYazdir(sesliHarf);
            //sesliHarf.SymmetricExceptWith(alfabe);
            //KoleysiyonYazdir(sesliHarf);
        }

        static void KoleysiyonYazdir(IEnumerable koleysiyon)
        {
            Console.WriteLine();
            int i = 0;
            foreach (char c in koleysiyon)
            {
                Console.Write($"{c,5}");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("Eleman sayisi : {0}",i);
            Console.WriteLine();
        }

        private static void SortedSetPractice()
        {
            //SortedSet Küme İşlemleri
            //var A = new SortedSet<int>() { 1, 2, 3, 4 };
            var A = new SortedSet<int>(RastgeleSayiUret(10000));
            var B = new SortedSet<int>(RastgeleSayiUret(10000));
            //var B = new SortedSet<int>() { 1, 2, 5, 6 };

            #region yazdirma
            Console.WriteLine();
            Console.WriteLine("A kümesi");
            foreach (int s in A)
            {
                Console.Write($"{s,5}");
            }

            Console.WriteLine();
            Console.WriteLine("B kümesi");
            foreach (int s in B)
            {
                Console.Write($"{s,5}");
            }
            #endregion
            Console.WriteLine();

            //Union
            //A.UnionWith(B);

            //Console.WriteLine("\n\nA ve B kümesinin birleşimi");
            //foreach (int s in A) 
            //{
            //    Console.Write($"{s,5}");
            //}
            //Console.WriteLine();
            //Console.WriteLine("\nToplam sayisi : {0}", A.Count);
            //Console.WriteLine();

            //Kesişim
            //A.IntersectWith(B);
            //Console.WriteLine("\n\nA ve B kümesinin kesişimi");
            //foreach (int s in A)
            //{
            //    Console.Write($"{s,5}");
            //}
            //Console.WriteLine();
            //Console.WriteLine("\nToplam sayisi : {0}", A.Count);


            //Console.WriteLine();

            //Sadece A veya B kümesindeki elemanı seçme
            //A.ExceptWith( B );
            //Console.WriteLine();
            //Console.WriteLine("\n\nSadece A");
            //foreach (var s in A)
            //{
            //    Console.Write($"{s,5}");
            //}
            //Console.WriteLine();
            //Console.WriteLine("\nToplam sayisi : {0}", A.Count);
            //
            //
            //Console.WriteLine();

            //Kesişim dışındaki elemanları alma
            A.SymmetricExceptWith(B);

            Console.WriteLine();
            Console.WriteLine("\n\n Kesisim disindaki elemanlar");
            foreach (var s in A)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine();
            Console.WriteLine("\nToplam sayisi : {0}", A.Count);


            Console.WriteLine();
        }

        static List<int> RastgeleSayiUret(int n)
        {
            var list = new List<int>();
            var r = new Random();

            for (int i = 0; i < n; i++)
            {
                list.Add(r.Next(0, 1000));    
            }
            return list;
        }

        private static void SortedSetApp()
        {
            //SortedSet

            var sayilar = new List<int>();
            var r = new Random();

            Console.WriteLine();
            for (int i = 0; i < 1000; i++)
            {
                sayilar.Add(r.Next(5, 25));
                Console.Write($"{sayilar[i],-3}");
            }
            Console.WriteLine();

            //Listedeki benzersiz elemanları bulmak
            var benzersizSayiListesi = new SortedSet<int>(sayilar);

            Console.WriteLine("\nBenzersiz Sayilarin Listesi\n");
            foreach (int item in benzersizSayiListesi)
            {
                Console.Write($"{item,-3}");
            }
            Console.WriteLine();
            Console.WriteLine("\nBenzersiz {0} sayi var.", benzersizSayiListesi.Count);
        }

        private static void SortedSetBasics()
        {
            //SortedSet
            //Tanımlama

            var list = new SortedSet<string>();

            //Ekleme
            if (list.Add("Mehmet"))
            {
                Console.WriteLine("Mehmet eklendi");
            }
            else
            {
                Console.WriteLine("Ekleme başarısız");
            }

            Console.WriteLine("{0}", list.Add("Ahmet") == true ? "Ahmet Eklendi" : "Ekleme başarısız.");

            list.Add("Sule");
            list.Add("Neslihan");
            list.Add("Fahrettin");
            list.Add("Fatih");

            list.Remove("Sule");
            list.RemoveWhere(deger => deger.StartsWith("F"));

            Console.WriteLine("\nİsimler listesi\n");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Eleman sayisi        :{0,3}", list.Count);
        }

        private static void SortedDictionaryApp()
        {
            //Sorted Dictionary
            var kitapIndeks = new SortedDictionary<string, List<int>>()
            {
                {"HTML",new List<int>(){8,10,12} },
                {"CSS",new List<int>(){70,80,90} },
                {"LQuery",new List<int>(){3,5,15} },
                {"SQL",new List<int>(){70,80} }
            }
            ;
            kitapIndeks.Add("FTP", new List<int>() { 3, 5, 7 });
            kitapIndeks.Add("ASP.NET", new List<int>() { 50, 60 });

            foreach (var kavram in kitapIndeks)
            {
                Console.WriteLine($"{kavram.Key}");
                kavram.Value.ForEach(s => Console.WriteLine($"\t > {s,-5} pp"));
            }
        }

        private static void DictionaryApp()
        {
            //Dictionary
            var personelListesi = new Dictionary<int, Personel>()
            {
                {110, new Personel("Mehmet","Sonsoz",7500) },
                {120, new Personel("Ahmet","Can",9000) },
            };
            personelListesi.Add(100, new Personel("Zeynep", "Coskun", 5000));
            foreach (var p in personelListesi)
            {
                Console.WriteLine(p);
            }
        }

        private static void DictionaryBasics()
        {
            //Dictionary
            var telefonKodlari = new Dictionary<int, string>()
            {
                {332,"Konya" },
                {424,"Elazığ" },
                {466,"Art" },
                {422,"Malatya" },
            }
            ;

            //Ekleme
            telefonKodlari.Add(322, "Adana");
            telefonKodlari.Add(212, "İstanbul");
            telefonKodlari.Add(216, "İstanbul");

            //Erişme
            telefonKodlari[466] = "Artvin";

            //ContainsKey
            if (!telefonKodlari.ContainsKey(312))
            {
                Console.WriteLine("\aAnkaranın kod bilgisi tanımlı değil");
                telefonKodlari.Add(312, "Ankara");
                Console.WriteLine("Yeni kod eklendi");
            }

            //ContainsValue
            if (!telefonKodlari.ContainsValue("Malatya"))
            {
                Console.WriteLine("\aMalatyanın kod bilgisi tanımlı değil");
                telefonKodlari.Add(422, "Malatya");
                Console.WriteLine("Yeni kod eklendi");
            }

            //Çıkartma
            telefonKodlari.Remove(322);

            foreach (var item in telefonKodlari)
            {
                Console.WriteLine(item);
            }
        }

        private static void LinkedListApp()
        {
            //LinkedList<T> Temelleri
            //Tanımlama
            var sehirler = new LinkedList<string>();
            sehirler.AddFirst("Ordu");
            sehirler.AddFirst("Trabzon");
            sehirler.AddLast("İstanbul");
            sehirler.AddAfter(sehirler.Find("Ordu"), "Samsun");
            sehirler.AddBefore(sehirler.First.Next.Next, "Giresun");
            sehirler.AddAfter(sehirler.Last.Previous, "Sinop");
            sehirler.AddAfter(sehirler.Find("Sinop"), "Zonguldak");

            Console.WriteLine();
            Console.WriteLine("Gidiş Güzergahı");
            Console.WriteLine();
            var eleman = sehirler.First;

            while (eleman != null)
            {
                Console.WriteLine(eleman.Value);
                eleman = eleman.Next;
            }

            Console.WriteLine();
            Console.WriteLine("Dönüş Güzergahı");
            Console.WriteLine();

            var sonEleman = sehirler.Last;

            while (sonEleman != null)
            {
                Console.WriteLine(sonEleman.Value);
                sonEleman = sonEleman.Previous;
            }
        }

        private static void QueueApp()
        {
            var sesliHarfler = new List<char>()
            {
                'a','e','ı','i','u','ü','o','ö'
            };

            ConsoleKeyInfo secim;
            var kuyruk = new Queue<char>();
            foreach (char k in sesliHarfler)
            {
                Console.WriteLine($"{k,-5} kuyruğa eklensin mi? [e/h] ");
                secim = Console.ReadKey();
                Console.WriteLine();
                if (secim.Key == ConsoleKey.E)
                {
                    kuyruk.Enqueue(k);
                    Console.WriteLine($"\n{k,-5} kuyruğa eklendi.");
                    Console.WriteLine($"Kuyruktaki eleman sayısı : {kuyruk.Count}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Kuyruktan elemanların kaldırılması işlemi için Esc tuşuna basınız");
            secim = Console.ReadKey();
            if (secim.Key == ConsoleKey.Escape)
            {
                Console.WriteLine();

                while (kuyruk.Count > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{kuyruk.Peek()} kuyruktan çıkartılıyor");
                    Console.WriteLine($"{kuyruk.Dequeue(),-5} kuyruktan çıkartıldı.");
                    Console.WriteLine($"Kuyruktaki eleman sayısı : {kuyruk.Count}");

                }
                Console.WriteLine("\n Kuyruktan çıkarma işlemi tamamlandı.");
            }

            Console.WriteLine("Program bitti");
        }

        private static void QueueBasic()
        {
            //Queue
            //Tanımlama
            var karakterKuyguru = new Queue<char>();

            //Ekleme
            karakterKuyguru.Enqueue('a');
            karakterKuyguru.Enqueue('e');
            karakterKuyguru.Enqueue('i');
            karakterKuyguru.Enqueue('o');
            Console.WriteLine($"Eleman sayisi:  {karakterKuyguru.Count}");
            var dizi = karakterKuyguru.ToArray();

            //Çıkarma
            Console.WriteLine($"Kuyruğun ilk elemanı: {karakterKuyguru.Peek()}");
            Console.WriteLine($"{karakterKuyguru.Dequeue()} kuyruktan çıkarıldı.");
            Console.WriteLine($"Kuyruğun ilk elemanı: {karakterKuyguru.Peek()}");
        }

        private static void YiginApp()
        {
            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            var sayiYigini = new Stack<int>();

            while (sayi > 0)
            {
                int k = sayi % 10;
                sayiYigini.Push(k);
                sayi = sayi / 10;
            }

            int i = 0;
            int n = sayiYigini.Count - 1;

            foreach (var item in sayiYigini)
            {
                Console.WriteLine($"\t{item,7} x " +
                    $"{Math.Pow(10, n - i),7}\t = " +
                    $"{item * Math.Pow(10, n - i),7}");
                i++;
            }
        }

        private static void YiginBasic()
        {
            var karakterYigini = new Stack<char>();
            for (int i = 65; i <= 90; i++)
            {
                karakterYigini.Push((char)i);
                Console.WriteLine($"{karakterYigini.Peek()} yığına eklendi. ");
                Console.WriteLine($"Yığındaki eleman sayisi : {karakterYigini.Count}");
            }

            //Ek bilgi
            var dizi = karakterYigini.ToArray();

            Console.WriteLine("Yığından çıkartma işlemi için bir tuşa basınız");
            Console.WriteLine(karakterYigini.Count);
            Console.ReadKey();

            while (karakterYigini.Count > 0)
            {
                Console.WriteLine($"{karakterYigini.Pop()} yığından çıkarıldı.");
                Console.WriteLine($"Yığındaki eleman sayisi : {karakterYigini.Count}");
            }
        }

        private static void YiginGiris()
        {
            // Stack Tanımlama
            var karakterYigini = new Stack<char>();

            // Ekleme
            karakterYigini.Push('A');
            Console.WriteLine(karakterYigini.Peek());
            karakterYigini.Push('B');
            Console.WriteLine(karakterYigini.Peek());
            karakterYigini.Push('C');
            Console.WriteLine(karakterYigini.Peek());

            //Çıkarma
            Console.WriteLine(karakterYigini.Pop() + " yığından çıkartıldı.");
            Console.WriteLine(karakterYigini.Pop() + " yığından çıkartıldı.");
            Console.WriteLine(karakterYigini.Pop() + " yığından çıkartıldı.");
        }

        private static void ListApp()
        {
            // List
            var sayılar = new List<int>() { 53, 40, 14, 2, 3, 12, 15 };
            sayılar.Sort();
            sayılar.ForEach(s => Console.WriteLine(s));

            //Sehir Listesi

            var sehirler = new List<Sehir>()
            {
                new Sehir(6,"Ankara"),
                new Sehir(34,"İstanbul"),
                new Sehir(55,"Samsun"),
                new Sehir(44,"Malatya"),
                new Sehir(22,"Edirne"),
            };
            sehirler.Add(new Sehir(1, "Adana"));
            sehirler.Sort();
            sehirler.ForEach(s => Console.WriteLine(s));
        }

        private static void SortedListAPP()
        {
            //SortedList
            var kitapIcerigi = new SortedList();
            kitapIcerigi.Add(1, "Önsöz");
            kitapIcerigi.Add(50, "Değişkenler");
            kitapIcerigi.Add(40, "Operatörler");
            kitapIcerigi.Add(60, "Döngüler");
            kitapIcerigi.Add(45, "İlişkisel Operatörler");

            Console.WriteLine("İçindekiler");
            Console.WriteLine(new string('-', 25));
            Console.WriteLine($"{"Konular",-30} {"Sayfalar",5}");
            foreach (DictionaryEntry item in kitapIcerigi)
            {
                Console.WriteLine($"{item.Value,-30}  {item.Key,5}");
            }
        }

        private static void SortedListBasic()
        {
            //tanımlama
            var list = new SortedList()
            {
                {1,"Bir" },
                {2,"İki" },
                {3,"Üç" },
                {8,"Sekiz" },
                {5,"Beş" },
                {6,"Altı" }
            };

            //Dolaşma
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            //Ekleme
            list.Add(4, "Dört");

            Console.WriteLine("");
            //Dolaşma
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.WriteLine("Listedeki eleman sayısı: {0}", list.Count);
            Console.WriteLine("Listenin kapasitesi:" + list.Capacity);
            list.TrimToSize();
            Console.WriteLine("Listenin eleman sayısı ile trimlenmiş kapasitesi: {0}", list.Capacity);

            //Erişme
            //Key
            Console.WriteLine(list[4]);
            //Index
            Console.WriteLine(list.GetByIndex(4));
            //Get-->Key
            Console.WriteLine(list.GetKey(4));
            //Listenin son elemanının değeri
            Console.WriteLine(list.GetByIndex(list.Count - 1));

            var anahtarlar = list.Keys;
            Console.WriteLine("\nAnahtarlar");
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }

            var degerler = list.Values;
            Console.WriteLine("\nDeğerler");
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nGüncelleme");
            if (list.ContainsKey(1))
            {
                list[1] = "One";
            }

            //Dolaşma
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine("\nSilme");
            list.Remove(4);
            //Dolaşma
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }

        private static void HashTableApp()
        {
            //Hashtable Uygulaması

            //başlığı okuma
            Console.WriteLine("Başlık giriniz");
            string baslik = Console.ReadLine();

            //kucultme
            baslik = baslik.ToLower();

            //Hashtable
            var karakterSeti = new Hashtable()
            {
                {'ç','c' },
                {'ı','i' },
                {'ö','o' },
                {'ü','u' },
                {'ğ','g' },
                {' ','-' },
                {'\'','-' },
                {'.','-' },
                {'?','-' }
            };

            foreach (DictionaryEntry item in karakterSeti)
            {
                baslik = baslik.Replace((char)item.Key, (char)item.Value);
            }

            //Ekranda Yazdir
            Console.WriteLine(baslik);
        }
    }
}
