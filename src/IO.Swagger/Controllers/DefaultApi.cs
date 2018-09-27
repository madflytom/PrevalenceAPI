/*
 * Disease Prevalence API
 *
 * The purpose is to provide a population prevalence for a given disease and country.  Using the country population and a disease prevalence factor, a potential patient population for the disease can be returned.
 *
 * OpenAPI spec version: 0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class DefaultApiController : Controller
    { 

        private readonly PrevalenceContext _context;

        public DefaultApiController(PrevalenceContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Deletes a prevalance
        /// </summary>
        /// <remarks>Delete a single prevalence object identified via its countryName and diseaseName</remarks>
        /// <param name="countryName">The country&#39;s name</param>
        /// <param name="diseaseName">The disease name</param>
        /// <response code="204">Prevalance successfully deleted.</response>
        /// <response code="404">Prevalence does not exist.</response>
        /// <response code="500">An unexpected error occured.</response>
        [HttpDelete]
        [Route("/ctos-design/IndicationPrevalenceAPI/0.1/prevalence/{countryName}/{diseaseName}")]
        [ValidateModelState]
        [SwaggerOperation("PrevalenceCountryNameDiseaseNameDelete")]
        [SwaggerResponse(statusCode: 500, type: typeof(Error), description: "An unexpected error occured.")]
        public async Task<IActionResult> PrevalenceCountryNameDiseaseNameDelete([FromRoute][Required]string countryName, [FromRoute][Required]string diseaseName)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Error));

            var prevs = _context.Prevalence.Where(x => x.CountryName == countryName && x.DiseaseName == diseaseName).ToArray();

            if(prevs.Count() == 0){
                return StatusCode(404);
            }

            if (ModelState.IsValid)
            {
                _context.RemoveRange(prevs);
                await _context.SaveChangesAsync();
                return StatusCode(204);
            }
            else {
                return StatusCode(500, default(Error));
            }
        }

        /// <summary>
        /// Gets a prevalence for a country
        /// </summary>
        /// <remarks>Returns a single country prevalance for a disease name.</remarks>
        /// <param name="countryName">The country&#39;s name</param>
        /// <param name="diseaseName">The disease name</param>
        /// <response code="200">A Prevalance factor</response>
        /// <response code="404">Prevalence does not exist.</response>
        /// <response code="500">An unexpected error occured.</response>
        [HttpGet]
        [Route("/ctos-design/IndicationPrevalenceAPI/0.1/prevalence/{countryName}/{diseaseName}")]
        [ValidateModelState]
        [SwaggerOperation("PrevalenceCountryNameDiseaseNameGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Prevalence), description: "A Prevalance factor")]
        [SwaggerResponse(statusCode: 500, type: typeof(Error), description: "An unexpected error occured.")]
        public virtual IActionResult PrevalenceCountryNameDiseaseNameGet([FromRoute][Required]string countryName, [FromRoute][Required]string diseaseName)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Prevalence));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Error));

            var prev = _context.Prevalence.Where(x => x.DiseaseName == diseaseName && x.CountryName == countryName).FirstOrDefault();

            //TODO: Change the data returned
            return new ObjectResult(prev);
        }

        /// <summary>
        /// Creates a prevalence
        /// </summary>
        /// <remarks>Adds a new prevalence object to the prevalence list.</remarks>
        /// <param name="prevalance">The prevalance to create.</param>
        /// <response code="204">Prevalance succesfully created.</response>
        /// <response code="400">Prevalance couldn&#39;t have been created.</response>
        /// <response code="500">An unexpected error occured.</response>
        [HttpPost]
        [Route("/ctos-design/IndicationPrevalenceAPI/0.1/prevalence")]
        [ValidateModelState]
        [SwaggerOperation("PrevalencePost")]
        [SwaggerResponse(statusCode: 500, type: typeof(Error), description: "An unexpected error occured.")]
        public async Task<IActionResult> PrevalencePost([FromBody]Prevalence prevalance)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Error));


            if (ModelState.IsValid)
            {
                _context.Add(prevalance);
                await _context.SaveChangesAsync();
                return Ok(prevalance);
            }
            else {
                return StatusCode(500, default(Error));
            }
        }
    }
}
