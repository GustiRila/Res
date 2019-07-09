using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Toko> listToko = new List<Toko>();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine();
                Console.WriteLine("Menu :\n1. Tambah\n2. Hapus\n3. Tampilkan\n4. Keluar");
                Console.Write("Pilihan: ");
                int ch = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();
                switch (ch)
                {
                    case 1:
                        Tambah();
                        break;
                    case 2:
                        Hapus();
                        break;
                    case 3:
                        Tampilkan();
                        break;
                    case 4:
                        Keluar();
                        break;
                }
            }

            void Tambah()
            {
                Toko tk = new Toko();

                Console.Write("Kode Barang: ");
                tk.Kode = Console.ReadLine();
                Console.Write("Nama Barang: ");
                tk.Nama = Console.ReadLine();
                Console.Write("Harga Beli: ");
                tk.Beli = Console.ReadLine();
                Console.Write("Harga Jual: ");
                tk.Jual = Console.ReadLine();

                listToko.Add(tk);
            }

            void Hapus()
            {
                Console.Write("Masukkan Kode Produk: ");
                string search = Console.ReadLine();

                int index = 0;
                foreach (Toko tk in listToko)
                {
                    if (tk.Kode == search)
                    {
                        break;
                    }

                    index++;
                }
                listToko.RemoveAt(index);
            }

            void Tampilkan()
            {
                Console.WriteLine("Kode Produk\t\tNama\t\tHargaBeli\t\tHargaBeli");

                int index = 0;
                foreach (Toko tk in listToko)
                {
                    Console.WriteLine("{0}\t\t\t{1}\t\t{2}\t\t\t{3}", tk.Kode, tk.Nama, tk.Beli, tk.Jual);
                    index++;
                }
            }

            void Keluar()
            {
                exit = true;
            }
        }
    }
}

