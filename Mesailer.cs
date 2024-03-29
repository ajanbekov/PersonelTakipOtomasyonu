﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipOtomasyonu
{
    internal class Mesailer
    {
        #region Mesai Kapsulleme
        private int _MesaiID;
        private string _BaslangicSaati;
        private string _BitisSaati;
        private decimal _SaatUcreti;
        private decimal _Tutar;
        private string _Donem;
        private string _OdenmeDurumu;
        private string _Aciklama;
        private DateTime _Tarih;

        public int MesaiID { get => _MesaiID; set => _MesaiID = value; }
        public string BaslangicSaati { get => _BaslangicSaati; set => _BaslangicSaati = value; }
        public string BitisSaati { get => _BitisSaati; set => _BitisSaati = value; }
        public decimal SaatUcreti { get => _SaatUcreti; set => _SaatUcreti = value; }
        public decimal Tutar { get => _Tutar; set => _Tutar = value; }
        public string Donem { get => _Donem; set => _Donem = value; }
        public string OdenmeDurumu { get => _OdenmeDurumu; set => _OdenmeDurumu = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        #endregion
    }
}
