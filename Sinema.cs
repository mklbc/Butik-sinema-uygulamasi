using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButikSinemaUygulamasi_TP195
{
    internal class Sinema
    {
        public string Film;
        public int Kapasite;
        public int TamBiletFiyati;
        public int YarimBiletFiyati;
        public int ToplamTamBiletAdeti;
        public int ToplamYarimBiletAdeti;
        public float Ciro;
        public int BosKoltukAdeti;

        //Program tarafında alınan "film, kapasite, tam bilet fiyatı gibi bilgileri buraya gönderiyoruz.
        public Sinema(string filmAdi, int kapasite, int tam,int yarim)
        {
            //Alınan bilgiler özelliklere atam opertörü ile aktrılıyor.
            this.Film = filmAdi;
            this.Kapasite = kapasite;
            this.TamBiletFiyati = tam;
            this.YarimBiletFiyati = yarim;
            
        }

        public void BiletSatisi(int tamBiletAdeti, int yarimBiletAdeti)
        {
            this.ToplamTamBiletAdeti += tamBiletAdeti;
            this.ToplamYarimBiletAdeti += yarimBiletAdeti;
        }

        public void Biletiadesi(int iadetambilet, int iadeyarimbilet)
        {
            this.ToplamTamBiletAdeti -= iadetambilet;
            this.ToplamYarimBiletAdeti -= iadeyarimbilet;
        }

        public void boskoltukadeti()
        {
            this.BosKoltukAdeti = this.Kapasite - (ToplamTamBiletAdeti + ToplamYarimBiletAdeti);
        }

    }


}
