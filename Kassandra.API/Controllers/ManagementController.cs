using Kassandra.API.Models.Response;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using System.Reflection;

namespace Kassandra.API.Controllers
{
    /// <summary>
    /// Controller Management
    /// </summary>
    [Route("/")]
    [ApiController]
    public class ManagementController : ControllerBase
    {
        private readonly IWebHostEnvironment Env;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="env"></param>
        public ManagementController(IWebHostEnvironment env)
        {
            Env = env;
        }

        /// <summary>
        /// Get current version of the Kassandra template
        /// </summary>
        public string CurrentVersion
        {
            get
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                Version version = assembly.GetName().Version;
                return version.ToString();
            }
        }

        /// <summary>
        /// Used as a Health endpoint. Return some information about kassandra framework 
        /// </summary>
        /// <response code="200">Kassandra healthy</response>
        [ProducesResponseType(200, Type = typeof(KassandraVersionResponse))]
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(new KassandraVersionResponse
            {
                Core = "Kassandra.NET",
                Version = CurrentVersion,
                Project = "github.com/viamus/kassandra",
                Environment = Env.IsDevelopment()? "Development" : "Production"
            } );
        }
    }
}