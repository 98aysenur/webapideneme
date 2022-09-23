﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapideneme.Models
{
    public static class Veritabani
    {
        private static Dictionary<string, DavetiyeModel> _liste;
        static Veritabani()
        {
            _liste=new Dictionary<string,DavetiyeModel> ();
            _liste.Add("Hasan", new DavetiyeModel
            {
                Ad = "Hasan",
                Eposta = "hasan@gmail.com",
                KatilmaDurumu = true
            });


            _liste.Add("Mehmet", new DavetiyeModel
            {
                Ad = "Mehmet",
                Eposta = "mehmet@gmail.com",
                KatilmaDurumu = false
            });
            _liste.Add("Berrin", new DavetiyeModel
            {
                Ad = "Berrin",
                Eposta = "berrin@gmail.com",
                KatilmaDurumu = true
            });
            _liste.Add("Ayşenur", new DavetiyeModel
            {
                Ad = "Ayşenur",
                Eposta = "ayşenur@gmail.com",
                KatilmaDurumu = true
            });
            _liste.Add("Zeyneb", new DavetiyeModel
            {
                Ad = "Zeyneb",
                Eposta = "zeyneb@gmail.com",
                KatilmaDurumu = false
            });
            _liste.Add("Öznur", new DavetiyeModel
            {
                Ad = "Öznur",
                Eposta = "öznur@gmail.com",
                KatilmaDurumu = false
            });
            _liste.Add("Sena", new DavetiyeModel
            {
                Ad = "Sena",
                Eposta = "sena@gmail.com",
                KatilmaDurumu = true
            });
        }
        public static void Add(DavetiyeModel model)
        {
            string key = model.Ad.ToLower();
            if (_liste.ContainsKey(key))
            {
                _liste[key] = model;
            }
            else
            {
                _liste.Add(key, model);

            }
        }
        public static IEnumerable<DavetiyeModel> Liste
        {
            get { return _liste.Values; }
        }
    }





















}