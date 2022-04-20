using System;

namespace QAOA
{
    public class RequestModel
    {
        public String request_id { get; set; }
        public String user_id { get; set; }
        public String feature_type { get; set; }
        
        public inputData input { get; set; }
    }

    public class inputData
    {
        public pipelineData pipeline { get; set; }
        public string device { get; set; }
        public quboData qubo { get; set; }
    }

    public class pipelineData
    {
        public string algorithm { get; set; }
        public int depth { get; set; }
        public string optimizer { get; set; }
        public int shots { get; set; }
    }

    public class quboData
    {
        public int num_variables { get; set; }
        public string edges { get; set; }
        public string weights { get; set; }
    }
}
