using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class MovementController : Controller
    {
        // GET: Movement
        public ActionResult Index()
        {
            eAirlinesEntities db = new eAirlinesEntities();

            List<movementsFlightsView> movList = db.movementsFlightsView.ToList();

            movementVFlights movVM = new movementVFlights();

            List<movementVFlights> movVMList = movList.Select(x => new movementVFlights
            {
                movementId = x.movementId,
                arr_flightNumer = x.arr_flightNumer,
                dep_flightNumber = x.dep_flightNumber,
                airlineIATA = x.airlineIATA,
                arr_scheduleTime = Convert.ToDateTime(x.arr_scheduleTime),
                dep_schedTime = Convert.ToDateTime ( x.dep_schedTime),
                registration = x.registration,
                arrivalFlightId = Convert.ToInt32(x.arrivalFlightId),
                departureFlightId = Convert.ToInt32(x.departureFlightId),
                flight_from = x.flight_from,
                flight_to = x.flight_to,
                MTOW = Convert.ToInt32(x.MTOW)
            }).ToList();

            
            return View(movVMList);
        }

        // GET: Movement/Details/5
        public ActionResult Details(int mov_id, int arr_id, int dep_id)
        {
            eAirlinesEntities db = new eAirlinesEntities();

            List<ArrivalOrderView> arrList = db.ArrivalOrderView.Where(x => x.arrival_id == arr_id).ToList();

            ArrivalOrderV arrVM = new ArrivalOrderV();

            List<ArrivalOrderV> arrVMList = arrList.Select(x => new ArrivalOrderV
            {
                name = x.name,
                start_time = x.start_time,
                status = x.status,
                arrival_id = x.arrival_id
            }).ToList();

            List<DepartureOrderView> depList = db.DepartureOrderView.Where(x => x.departure_id == dep_id).ToList();

            DepartureOrderV depVM = new DepartureOrderV();

            List<DepartureOrderV> depVMList = depList.Select(x => new DepartureOrderV
            {
                name = x.name,
                start_time = x.start_time,
                status = x.status,
                departure_id = x.departure_id
            }).ToList();

            ViewData["mov_id"] = mov_id;
            ViewData["arrOrderList"] = arrVMList;
            ViewData["depOrderList"] = depVMList;
            return View();
        }

        public ActionResult Report(string id, int mov_id)
        {
            LocalReport lr = new LocalReport();
            string path = Path.Combine(Server.MapPath("~/Report"), "SupplyList.rdlc");
            if (System.IO.File.Exists(path))
            {
                lr.ReportPath = path;
            }
            else
            {
                return View("Index");
            }
            //List<StateArea> cm = new List<StateArea>();
            //using (PopulationEntities dc = new PopulationEntities())
            //{
            //    cm = dc.StateAreas.ToList();
            //}

            eAirlinesEntities db = new eAirlinesEntities();

            List<movementsFlightsView> cm = new List<movementsFlightsView>();
            using (eAirlinesEntities dc = new eAirlinesEntities())
            {
                cm = dc.movementsFlightsView.Where(x => x.movementId == mov_id).ToList();

            }


            int arr_id = Convert.ToInt32(cm[0].arrivalFlightId);
            List<ArrivalOrderView> arrList = db.ArrivalOrderView.Where(x => x.arrival_id == arr_id).ToList();

            //ArrivalOrderV arrVM = new ArrivalOrderV();

            //List<ArrivalOrderV> arrVMList = arrList.Select(x => new ArrivalOrderV
            //{
            //    name = x.name,
            //    start_time = x.start_time,
            //    status = x.status,
            //    arrival_id = x.arrival_id
            //}).ToList();

            int dep_id = Convert.ToInt32(cm[0].departureFlightId);
            List<DepartureOrderView> depList = db.DepartureOrderView.Where(x => x.departure_id == dep_id).ToList();

            //DepartureOrderV depVM = new DepartureOrderV();

            //List<DepartureOrderV> depVMList = depList.Select(x => new DepartureOrderV
            //{
            //    name = x.name,
            //    start_time = x.start_time,
            //    status = x.status,
            //    departure_id = x.departure_id
            //}).ToList();

            ReportDataSource rd = new ReportDataSource("MovementDataSet", cm);
            ReportDataSource rd1 = new ReportDataSource("ArrivalOrdersDataset", arrList);
            ReportDataSource rd2 = new ReportDataSource("DepartureOrdersDataset", depList);
            lr.DataSources.Add(rd);
            lr.DataSources.Add(rd1);
            lr.DataSources.Add(rd2);
            string reportType = id;
            string mimeType;
            string encoding;
            string fileNameExtension;



            string deviceInfo =

            "<DeviceInfo>" +
            "  <OutputFormat>" + id + "</OutputFormat>" +
            "</DeviceInfo>";

            Warning[] warnings;
            string[] streams;
            byte[] renderedBytes;

            renderedBytes = lr.Render(
                reportType,
                deviceInfo,
                out mimeType,
                out encoding,
                out fileNameExtension,
                out streams,
                out warnings);

            return File(renderedBytes, mimeType);
        }
        // GET: Movement/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movement/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movement/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Movement/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movement/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Movement/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
