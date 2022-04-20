using System;

namespace QAOA
{
    public class ResponseModel
    {
        public String status { get; set; }
        public Array optimal_solution { get; set; }
        public Double optimal_energy { get; set; }
        
        public Array optimal_parameters { get; set; }
    }
}
