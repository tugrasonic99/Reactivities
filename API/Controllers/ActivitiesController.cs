using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController : BaseAPIController
    {
        private readonly DataContext _context;

        public ActivitiesController(DataContext context){
            _context = context;
        }


        [HttpGet] //api/activities
        public async Task<ActionResult<List<Activity>>> getActivities(){

            return await _context.Activities.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> getActivity(Guid id){

            return await _context.Activities.FindAsync(id);
        }
        
    }
}