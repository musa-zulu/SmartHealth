using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SmartHealth.Core.Interfaces.Repositories;
using AutoMapper;
using SmartHealth.Web.ViewModels;
using SmartHealth.Core.Domain;
using SmartHealth.Core;
using Microsoft.AspNet.Identity;

namespace SmartHealth.Web.Controllers
{
    public class PatientsController : Controller
    {
        readonly IPatientRepository _ipatientsRepository;
        readonly IMappingEngine _mappingEngine;
        private IDateTimeProvider _dateTimeProvider;

        public PatientsController(IPatientRepository patientsRepository, IMappingEngine mappingEngine)
        {
            _ipatientsRepository = patientsRepository;
            _mappingEngine = mappingEngine;            
        }

        public IDateTimeProvider DateTimeProvider
        {
            get { return _dateTimeProvider ?? (_dateTimeProvider = new DefaultDateTimeProvider()); }
            set
            {
                if (_dateTimeProvider != null) throw new InvalidOperationException("DateTimeProvider is already set");
                _dateTimeProvider = value;
            }
        }

        public ActionResult Index()
        {
            var patientViewModel = new List<PatientViewModel>();
            var patients = _ipatientsRepository.GetAll();
            if (patients != null)
                patientViewModel = _mappingEngine.Map<List<Patient>, List<PatientViewModel>>(patients);
            return View(patientViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PatientViewModel patientViewModel)
        {
            if (ModelState.IsValid)
            {
                SetBaseFieldsOn(patientViewModel);              
                var patient = _mappingEngine.Map<PatientViewModel, Patient>(patientViewModel);
                _ipatientsRepository.Save(patient);
                return RedirectToAction("Index","Patients");
            }
            return View(patientViewModel);
        }

        private void SetBaseFieldsOn(PatientViewModel patientViewModel)
        {
            patientViewModel.CreatedUsername = GetUserName();
            patientViewModel.LastModifiedUsername = GetUserName();
            patientViewModel.DateCreated = DateTimeProvider.Now;
            patientViewModel.DateLastModified = DateTimeProvider.Now;
        }

        private string GetUserName()
        {
            var username = "";
            if (User?.Identity != null)
                username = User.Identity.GetUserName();
            return username;
        }
    }
}