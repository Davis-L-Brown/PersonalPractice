using System;

namespace DataVisualization.Interfaces
{
    public interface ICity
    {
        string Name { get; set; }
        double Population { get; set; }
        DateTime FoundingDate { get; set; }
    }
}
