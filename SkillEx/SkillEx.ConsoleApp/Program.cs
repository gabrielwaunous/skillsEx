using SkillEx.Repository.Core;
using SkillEx.Repository.Core.Interfaces;
using SkillEx.Repository.Helpers;
using SkillEx.Repository.Helpers.Loggers;
using SkillEx.Repository.Helpers.Serializers;
using SkillEx.Repository.Helpers.Seeds;
using System;

namespace SkillEx.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.Log("Pharmacy Business Manager Solution v0.1");

            logger.Log("¡¡Starting Claim Import Tool flow!!");

            var engine = new ClaimEngine(
                logger,
                new JsonFileClaimSource(),
                //new XmlFileClaimSource(),
                new JsonClaimSerializer(),
                //new XmlClaimSerializer(),
                new ClaimFactory(logger, new ImportProcess())
            );

            engine.ImportProcess();
            logger.Log("\n\n¡¡Ending Claim Import Tool flow!!");
        }
    }
}
