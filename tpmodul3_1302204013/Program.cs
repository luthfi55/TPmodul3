using System;
using System.Collections.Generic;

namespace tpmodul3_1302204013
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            KodePos table_Kodepos = new KodePos();
            Console.WriteLine("Get Kode Pos Mengger :\n ");
            table_Kodepos.getKodepos("Mengger");
            Console.WriteLine("\nGet All Kode Pos :\n ");
            Console.WriteLine("Kelurahan \t Kode Pos\n");
            table_Kodepos.getAllkodepos();

            Console.WriteLine("\nKunci Pintu :\n");
            DoorMachine pintu = new DoorMachine();
            pintu.kunci();
        }

    }
    class KodePos
    {

        Dictionary<string, string> dict = new Dictionary<string, string>() {
            {"Batununggal", "40266"},
            {"Kujangsari","40287" },
            {"Mengger"  ,"40267" },
            {"Wates"    ,"40256" },
            {"Cijaura"  ,"40287"},
            {"Jatisari" ,"40286" },
            {"Margasari","40286"},
            {"Sekejati" ,"40286" },
            {"Kebonwaru","40272"},
            {"Maleer"   ,"40274"},
            {"Samoja"   ,"40273"} };

        public void getKodepos(string kelurahan)
        {
            if (dict.ContainsKey(kelurahan))
            {
                Console.WriteLine("Kelurahan \t Kode Pos\n");
                Console.WriteLine(kelurahan + " \t " + dict[kelurahan]);
            }
            else
            {
                Console.WriteLine(kelurahan + " tidak ditemukan");
            }
        }

        public void getAllkodepos()
        {
            foreach (KeyValuePair<string, string> isi in dict)
            {
                Console.WriteLine("{0}   \t {1}", isi.Key, isi.Value);
            }
        }
    }

    class DoorMachine
    {
        enum State { Terkunci, Terbuka };
        public void kunci() 
        {
            State state = State.Terkunci;

            String[] screenName = { "terkunci", "terbuka" };
            do
            {
                Console.WriteLine("\nPintu " + screenName[(int)state] + " \n");
                Console.Write("Masukkan perintah : ");
                String command = Console.ReadLine();
                switch (state)
                {
                    case State.Terkunci:
                        if (command == "Buka Pintu")
                        {
                            state = State.Terbuka;
                        }
                        break;
                    case State.Terbuka:
                        if (command == "Kunci Pintu")
                        {
                            state = State.Terkunci;
                        }
                        break;



                }
            } while (state != State.Terkunci);
        }

    }
}