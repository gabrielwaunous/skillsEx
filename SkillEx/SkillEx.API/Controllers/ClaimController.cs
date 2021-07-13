using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkillEx.Repository.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SkillEx.API.Controllers
{

    public class ClaimController : Controller
    {
        private IClaimEngine _claimEngine { get; set; }

        public ClaimController(IClaimEngine claimEngine)
        {
            _claimEngine = claimEngine;
        }


        [HttpGet("ClaimController")]
        public FileStreamResult Details()
        {
            _claimEngine.ImportProcess();

            MemoryStream memoryStream = new MemoryStream();
            StreamWriter streamObject = new StreamWriter(memoryStream)
            {
                AutoFlush = true
            };
            FileStream fileStream = new FileStream("log.txt", FileMode.Open, FileAccess.Read);

            return new FileStreamResult(fileStream, "text/plain");
        }
    }
}
