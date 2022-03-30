namespace APISample.Dto
{
    public class ServiceOrderDetailDto
    {
        public Guid ServiceOrderId { get; set; }
        public Guid ServiceOrderDetailId { get; set; }

        public Guid ServiceOrderDetailStatusId { get; set; }
        public ServiceOrderDetailStatusDto ServiceOrderDetailStatus { get; set; }

        public string SMSServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceType { get; set; }
        public string EditableServiceProblem { get; set; }

        public int? Duration { get; set; }
        public double Cost { get; set; }
        public bool IsRecommenedService { get; set; }
        public DateTime CreatedDateTime { get; set; }

        public bool IsActive { get; set; }


    }
}
