namespace PROG6212.Models
{
    public class VerificationModel
    {
        public int ClaimId { get; set; }
        public string ApproverName { get; set; }
        public string Status { get; set; } // Approved, Rejected
        public string Comments { get; set; }
    }
}