using System;
using System.Collections.Generic;
using System.Text;

namespace AtcoDataLibrary
{
    public class ATCO : Employee
    {
        public int CertificateId { get; set; }

        public ATCO(int certificateId, int id, string name) : base( id,  name)
        {
            CertificateId = certificateId;
        }

        public override double GetHours(DateTime dt)
        {
            if (HoursWorked.ContainsKey(dt))
                return HoursWorked[dt];
            else
                return 0;
        }

        public void RegisterHours(double hours, DateTime dt)
        {
            if (HoursWorked.ContainsKey(dt))
                HoursWorked[dt] += hours;
            else
                HoursWorked.Add(dt, hours);
        }
    }
}
