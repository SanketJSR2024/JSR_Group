namespace Models
{
    public class FactoryDetailsDTO
    {
        public int Id { get; set; }

        public int? DefectTypeId { get; set; }

        public string UnitOfMeasurement { get; set; }

        public string AcceptableMeasurement { get; set; }

        public string QuantityAcceptablePerModule { get; set; }

        public int? SoftwareId { get; set; }

        public int? AccCriteriaId { get; set; }
    }
}
