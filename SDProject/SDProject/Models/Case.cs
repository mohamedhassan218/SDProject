namespace SDProject.Models
{
    public class Case
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int FamilySize { get; set; }
        public float MonthlyEarnings { get; set; }
        public string Dieseases { get; set; }
        public string GeneralNotes { get; set; }
        public int ReportId { get; set; }
        public int CaseInspectorId { get; set; }
    }
}
