namespace Models
{
    public class AcceptanceCriteriaDTO
    {
        public int Id { get; set; }

        public int? DefectTypeId { get; set; }

        public string UnitOfMeasurement { get; set; }

        public string AcceptableMeasurement { get; set; }

        public string QuantityAcceptable { get; set; }

        public int? PDId { get; set; }
    }
}
