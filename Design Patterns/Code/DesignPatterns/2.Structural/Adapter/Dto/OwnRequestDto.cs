namespace DesignPatterns._2.Structural.Adapter.Dto
{
    /// <summary>
    /// Our DTO to manage request
    /// </summary>
    public class OwnRequestDto
    {
        public int Id { get; set; }
        public int AmountLoan { get; set; }
        public bool tieneReferenciasPersonales { get; set; }
    }
}
