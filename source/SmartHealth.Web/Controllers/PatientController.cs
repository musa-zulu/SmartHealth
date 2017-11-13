using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using SmartHealth.Core.Domain;
using SmartHealth.Core.Interfaces.Repositories;
using SmartHealth.Web.Models;

namespace SmartHealth.Web.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IMappingEngine _mappingEngine;
        public PatientController(IPatientRepository patientRepository, IMappingEngine mappingEngine)
        {
            if (patientRepository == null) throw new ArgumentNullException(nameof(patientRepository));
            if(mappingEngine == null) throw new ArgumentNullException(nameof(mappingEngine));
            _patientRepository = patientRepository;
            _mappingEngine = mappingEngine;
        }

        // GET
        public ActionResult Index()
        {
            var patients = _patientRepository.GetAll();
            var patientsViewModel = _mappingEngine.Map<List<Patient>, List<PatientsViewModel>>(patients);
            return View(patientsViewModel);
        }
    }
}