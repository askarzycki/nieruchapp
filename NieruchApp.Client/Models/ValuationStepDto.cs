namespace NieruchApp.Client.Models
{
    public class ValuationStepDto
    {
        public string Header { get; set; }

        public string Prompt { get; set; }

        public ValuationStepOptionDto[] Options { get; set; }
    }
}
