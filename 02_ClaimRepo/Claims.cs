using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClaimRepo
{
    public enum ClaimType { Car, Home, Theft };
    public class Claims
    {
        public int ClaimID { get; set; }
        public ClaimType TypeOfClaim { get; set; }
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid
        {
            get
            {
                TimeSpan validTime = DateOfClaim - DateOfIncident;
                if (validTime.Days <= 30)
                {
                    return true;
                }
                return false;
            }
        }
        public Claims() { }

        public Claims(int claimNumber, ClaimType typeOfClaim, string description, decimal claimAmount, DateTime incidentDate, DateTime claimDate)
        {
            ClaimID = claimNumber;
            TypeOfClaim = typeOfClaim;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = incidentDate;
            DateOfClaim = claimDate;
        }
    }
}
