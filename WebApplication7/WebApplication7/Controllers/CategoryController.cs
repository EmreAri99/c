using Microsoft.AspNetCore.Mvc;
using WebApplication7.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication7.Controllers
{
   

    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase

    {
        private readonly AppDbContext context;

        public CategoryController(AppDbContext context)
        {
            this.context = context;
        }


        // GET: api/<CategoryController>
        [HttpGet]
        public List<Category> Get()
        {
            return context.Categories.ToList();
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}", Name ="Get")]
        public IActionResult  GetById(int id)
        {
            var item context.Categories. Where(p=>p.Id == id).FirstOrDefault();
            if (item == null)
            {
                return NotFound();  

            }
            else
            {

                return Ok(item);    
            }
                    
          
        }


        // POST api/<CategoryController>
        [HttpPost]
        public IActionResult Post([FromBody] Category model)
        {
            if (model != null) { 
            
             context.categories.Add(model); 
                context.SaveChanges();
                return CreatedAtRoute("Get", new { Id = model.Id }, model);        ;
            }  
            else
            {
                return BadRequest; 


            }
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Category model)
        {

            if (model == null || model.Id != id)
            {
                return BadRequest();    

            }

            var item = context.Categories.Find(id);
            if (item == null) {

                return NotFound();
                
            
            }
               

            item.Title = model.Title;
            item.Description=model.Description;
            item.ModifiedOn=DateTime.Now;
            
            context.Categories.Update(item);
            Context.SaveChanges();

            return Ok(item);
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var item = context.Categories.Find(id);
            if (item == null) { 
            
            return (NotFound());

            }   
            context.Categories.Remove(item);
            context.SaveChanges();

            return Ok(item);    
        }
    }
}
