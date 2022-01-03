using System;

namespace WinForm
{
    
    public class ExternalEmployeeAttendanceLogModel
    {
        public long HrConfigId { get; set; }
        //public long BranchId { get; set; }
        public DateTime AttendanceTime { get; set; }
        public bool State { get; set; }
        //public bool IsMachine { get; set; }
        public string MachineNo { get; set; }
        public string EmployeeCode { get; set; }
    }
}