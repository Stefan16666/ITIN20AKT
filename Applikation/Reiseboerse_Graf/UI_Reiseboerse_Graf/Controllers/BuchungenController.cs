﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI_Reiseboerse_Graf.Controllers
{
    public class BuchungenController : Controller
    {
        // GET: Buchungen
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Lädt alle Buchungen aus der Datenbank zu einer bestimmten Reise
        /// </summary>
        /// <param name="reise_id"></param>
        /// <returns></returns>
        public ActionResult LadeAlleBuchungen(int reise_id)
        {

            return View();
        }



        /// <summary>
        /// Fügt eine Buchung hinzu
        /// </summary>
        /// <returns>den View zum Eingeben der Daten</returns>
        public ActionResult Hinzufuegen()
        {
            return View();
        }

        /// <summary>
        /// Fügt eine Buchung hinzu anhand des übergebenen Models
        /// </summary>
        /// <returns></returns>
        public ActionResult Hinzufuegen(BuchungsModel neueBuchung)
        {
            return View();
        }
    }
}