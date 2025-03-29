namespace Blazor_Models.Interfaces
{
    public interface ICar
    {
        string? Brand { get; set; }
        int Id { get; set; }
        int Mileage { get; set; }
        string Model { get; set; }
        int Year { get; set; }
    }
}