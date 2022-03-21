namespace GenericRepository.Entities
{
    public class Car: BaseEntity
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }
    }
}
