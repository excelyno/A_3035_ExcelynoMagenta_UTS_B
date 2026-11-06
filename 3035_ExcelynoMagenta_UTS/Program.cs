using System;
using System.Diagnostics.SymbolStore;
using _3035_ExcelynoMagenta_UTS;

namespace _3035_ExcelynoMagenta_UTS

{


    public class Agen
    {
        public string idAgen { get; set; }
        public string namaAgen { get; set; }
        public int stokAgen { get; set; }

        public Agen(string id, string nama, int stok)
        {
            idAgen = id;
            namaAgen = nama;
            stokAgen = stok;
        }


        public void TampilkanInfo()
        {
            Console.WriteLine(idAgen);
            Console.WriteLine(namaAgen);
            Console.WriteLine(stokAgen);
        }
    }
    abstract public class ProdukGalon
    {
        private int _stokGudang;
        private string idProduk;
        private string namaProduk;
        public int stokGudang
        {
            get
            {
                return _stokGudang;
            }
            set
            {
                if (stokGudang <= 0)
                {
                    Console.WriteLine("nilai stok gaboleh nol atau negatif");
                }
            }

        }


        public virtual void KurangiStok(int jumlah)
        {
            stokGudang -= jumlah;
        }
        public virtual void HitungBiaya(int jumlah)
        {
            stokGudang -= jumlah;
        }
        public virtual int lihatStok()
        {
            return stokGudang;
        }
    };

    class GalonAkua : ProdukGalon
    {
        private int harga = 20000;
        public override void HitungBiaya(int jumlah)
        {
            base.HitungBiaya(jumlah);
            int biaya = jumlah * harga;

        }
    }

    class GalonBerkeran : ProdukGalon
    {
        private int harga = 12000;
        public override void HitungBiaya(int jumlah)
        {
            base.HitungBiaya(jumlah);
            int biaya = jumlah * harga;

        }
    };

    public interface IDapatDidistribusikan
    {
        public void KirimPaket(int jumlah, int stok);
        
    };



    public class DistribusiGalon : ProdukGalon
    {
        
        public Agen namaAgent { get; set; }
        public int stok { get { return stokGudang; } set; }
        public ProdukGalon jenisProduk { get; set; }
        public int jumlahGalon { get; set; }
        
        }



    };

    class program
    {
        public static void Main()
        {
            Agen ikan = new Agen("1", "ikan", 100);

            Console.WriteLine(ikan.TampilkanInfo);
        }

    }



