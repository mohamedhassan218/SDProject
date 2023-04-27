namespace SDProject.Models
{
    public class Report
    {
        public int Id { get; set; }
        public int CaseId { get; set; }
        public bool IfDataValid { get; set; }
        public string TypeOfCase { get; set; }
        public string FinalConclusion { get; set; }

    }
}
