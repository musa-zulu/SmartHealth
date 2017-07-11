using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartHealth.Core.Interfaces.Repositories;
using AutoMapper;
using SmartHealth.Web.ViewModels;
using SmartHealth.Core.Domain;

namespace SmartHealth.Web.Controllers
{
    public class PatientsController : Controller
    {
        readonly IPatientRepository _ipatientsRepository;
        readonly IMappingEngine _mappingEngine;

        public PatientsController(IPatientRepository patientsRepository, IMappingEngine mappingEngine)
        {
            _ipatientsRepository = patientsRepository;
            _mappingEngine = mappingEngine;
        }
                
        public ActionResult Index()
        {
            var patientsViewModel = new List<PatientsViewModel>();
            var patients = _ipatientsRepository.GetAll();
            if (patients != null)
                patientsViewModel = _mappingEngine.Map<List<Patient>, List<PatientsViewModel>>(patients);
            return View(patientsViewModel);
        }
    }
}