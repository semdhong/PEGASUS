﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pegasus.Models.Profiles;
using Pegasus.Services.Profile;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pegasus.Api.Agent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IPersonProfileService _personService;
        public PersonController(IPersonProfileService personService)
        {
            _personService = personService;
        }
        // GET: api/<BarangayController>
        [HttpGet]
        public IEnumerable<PersonProfilesModel> GetPersonList()
        {
            return _personService.GetPersonProfiles();
        }
        [HttpGet]
        public IEnumerable<PersonProfilesModel> GetPersonLists()
        {
            return _personService.GetPersonProfiles();
        }

        // GET api/<BarangayController>/5
        [HttpGet("{id}")]
        public ActionResult<PersonProfilesModel> Get(int id)
        {
            return _personService.GetPersonProfile(id);
        }

        [HttpGet("{name}")]
        public ActionResult<PersonProfilesModel> GetName(string name)
        {
            return _personService.GetPersonProfile(name);
        }

        // POST api/<BarangayController>
        [HttpPost]
        public void Post(PersonProfilesModel model)
        {
            _personService.CreatePersonProfile(model);
        }

        // PUT api/<BarangayController>/5
        
        public void Put(PersonProfilesModel model)
        {
            _personService.UpdatePersonProfile(model);
        }

        // DELETE api/<BarangayController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
