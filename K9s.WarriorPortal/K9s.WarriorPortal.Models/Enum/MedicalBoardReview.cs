using System.ComponentModel;

namespace K9s.WarriorPortal.Models.Enum
{
    public enum MedicalBoardReview
    {
        Fit,

        Unfit,

        [Description("Not Reviewed")]
        NotReviewed
    }
}