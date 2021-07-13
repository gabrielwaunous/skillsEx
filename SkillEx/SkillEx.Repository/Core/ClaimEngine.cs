using SkillEx.Repository.Core.Interfaces;
using SkillEx.Repository.Core.Model;
using SkillEx.Repository.Core.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkillEx.Repository.Core
{
    public class ClaimEngine : IClaimEngine
    {
        private readonly ILogger _logger;
        private readonly IClaimsSource _claimSource;
        private readonly IClaimSerializer _claimSerializer;
        private readonly IClaimFactory _claimFactory;

        public ClaimEngine(
            ILogger logger,
            IClaimsSource claimSource,
            IClaimSerializer claimSerializer,
            IClaimFactory claimFactory
            )
        {
            _logger = logger;
            _claimSource = claimSource;
            _claimSerializer = claimSerializer;
            _claimFactory = claimFactory;
        }
        public void ImportProcess()
        {
            _logger.Log("\nStarting Import.");
            _logger.Log("\nLoading Claims.");

            string claimString = _claimSource.GetClaimsFromSource();

            IEnumerable<ClaimDTO> claimList = _claimSerializer.GetClaimFromString(claimString);

            _logger.Log("Claim Imported.");

            _claimFactory.ClaimProcessor(claimList);

            _logger.Log("Claim Reported.");
        }
    }
}
