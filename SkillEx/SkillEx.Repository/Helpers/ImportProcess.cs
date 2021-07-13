using SkillEx.Repository.Core.Interfaces;
using SkillEx.Repository.Core.Model;

namespace SkillEx.Repository.Helpers
{
    public class ImportProcess : IImportProcess
    {
        public void SaveClaim(ILogger Logger, Claim Claim)
        {
            //Logger.Log("Claim Number: " + Claim.Number + " - Type: " + Claim.Type + " - Date of Injury: " + Claim.DOI.ToShortDateString() + " - Claimant: " + Claim.Claimant.LastName + " " + Claim.Claimant.FirstName);
            //Improve with Reflection
            string output = "";
            foreach (var ClaimProperty in Claim.GetType().GetProperties())
            {
                output += ClaimProperty.Name + ": ";
                if (ClaimProperty.Name == "Claimant")
                {
                    foreach (var Claimant in ClaimProperty.GetValue(Claim, null)?.GetType().GetProperties())
                    {
                        output += Claimant.Name + ": " + Claimant.GetValue(ClaimProperty.GetValue(Claim, null), null)?.ToString();
                    }
                }
                else
                {
                    output += ClaimProperty.GetValue(Claim, null)?.ToString() + " - ";
                }
            }
            Logger.Log(output);
        }
    }
}
