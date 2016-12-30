using OmmitedDatabaseModel3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repro
{
    public class Initialize
    {
        Entity2 appointmentStatusHistory1;
        Entity8 center1;
        Entity12 insurance1;
        Entity14 patient1;
        Entity17 resource1;
        Entity20 service1;
        Entity22 speciality1;

        public Initialize()
        {
            appointmentStatusHistory1 = new Entity2 { Id = Guid.NewGuid() };
            center1 = new Entity8 { Id = Guid.NewGuid() };
            insurance1 = new Entity12 { Id = Guid.NewGuid() };
            patient1 = new Entity14 { Id = Guid.NewGuid() };
            resource1 = new Entity17 { Id = Guid.NewGuid() };
            service1 = new Entity20 { Id = Guid.NewGuid() };
            speciality1 = new Entity22 { Id = Guid.NewGuid() };

            speciality1.Entities20.Add(service1);

            service1.Entities8.Add(center1);
            service1.Entities12.Add(insurance1);
            service1.Entities17.Add(resource1);
            service1.Entity22 = speciality1;
            service1.Entity22Id = speciality1.Id;

            resource1.Entities8.Add(center1);
            resource1.Entities20.Add(service1);

            patient1.Entities12.Add(insurance1);

            insurance1.Entities14.Add(patient1);
            insurance1.Entities20.Add(service1);

            center1.Entities17.Add(resource1);
            center1.Entities20.Add(service1);
            center1.Entities22.Add(speciality1);
        }

        public Entity1 GenerateAppointment()
        {                   
            var appointment1 = new Entity1 { Id = Guid.NewGuid() };          
            appointmentStatusHistory1.Entity1 = appointment1;          
            appointmentStatusHistory1.Entity1Id = appointment1.Id;
            appointment1.Entities2.Add(appointmentStatusHistory1);
            appointment1.Entity8 = center1;          
            appointment1.Entity8Id = center1.Id;
            appointment1.Entity12 = insurance1;           
            appointment1.Entity12Id = insurance1.Id;           
            appointment1.Entity14 = patient1;            
            appointment1.Entity14Id = patient1.Id;            
            appointment1.Entity17 = resource1;            
            appointment1.Entity17Id = resource1.Id;            
            appointment1.Entity20 = service1;            
            appointment1.Entity20Id = service1.Id;            
            appointment1.Entity22 = speciality1;            
            appointment1.Entity22Id = speciality1.Id;
            
            patient1.Entities1.Add(appointment1);

            return appointment1;
        }
    }
}
