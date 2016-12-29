using AutoMapper;
using OmmitedDatabaseModel3;
using OmmitedDTOModel3;
using Repro;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperv5
{
    public class Reprov5
    {
        IMapper mapperEngineWithPreserveReferences;
        public void Run()
        {
            Configure();
            Map(1);
            Map(1);
        }

        private void Configure()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            mapperEngineWithPreserveReferences = ConfigureMapperWithPreserveReferences();
            stopwatch.Stop();
            Console.WriteLine($"v5 configure mapper runtime is: {stopwatch.Elapsed}");
        }

        private void Map(int number)
        {
            var list = new List<Entity1>();
            var initialize = new Initialize();
            for (int i = 0; i < number; i++)
            {
                list.Add(initialize.GenerateAppointment());
            }
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var appointmentsDTO = mapperEngineWithPreserveReferences.Map<List<EntityDTO1>>(list);
            stopwatch.Stop();
            Console.WriteLine($"v5 mapping runtime of {number} appointments with related entities is: {stopwatch.Elapsed}");

            //List of objects performing slow
            //Appointment
            //Resource
            //User
            //Role
            //Physician
            //Overcapacity
            //CallHistory
            //Availability
            //AppointmentStatusHistory

            var list2 = new List<Entity1>();
            for (int i = 0; i < number; i++)
            {
                var entity = new Entity1();
                list2.Add(entity);
            }
            stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 1; i++)
            {
                var DTOs = mapperEngineWithPreserveReferences.Map<List<EntityDTO1>>(list2);
            }
            stopwatch.Stop();
            Console.WriteLine($"v5 mapping runtime of {number} appointments is: {stopwatch.Elapsed}");

            var list3 = new List<Entity17>();
            for (int i = 0; i < number; i++)
            {
                var entity = new Entity17();
                list3.Add(entity);
            }
            stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 1; i++)
            {
                var DTOs = mapperEngineWithPreserveReferences.Map<List<EntityDTO17>>(list3);
            }
            stopwatch.Stop();
            Console.WriteLine($"v5 mapping runtime of {number} resources is: {stopwatch.Elapsed}");

            var list4 = new List<Entity25>(); 
            for (int i = 0; i < number; i++)
            {
                var entity = new Entity25();
                list4.Add(entity);
            }
            stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 1; i++)
            {
                var DTOs = mapperEngineWithPreserveReferences.Map<List<EntityDTO25>>(list4);
            }
            stopwatch.Stop();
            Console.WriteLine($"v5 mapping runtime of {number} users is: {stopwatch.Elapsed}");
        }

        private IMapper ConfigureMapperWithPreserveReferences()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Entity1, EntityDTO1>().ReverseMap();
                cfg.CreateMap<Entity2, EntityDTO2>().ReverseMap();
                cfg.CreateMap<Entity3, EntityDTO3>().ReverseMap();
                cfg.CreateMap<Entity4, EntityDTO4>().ReverseMap();
                cfg.CreateMap<Entity5, EntityDTO5>().ReverseMap();
                cfg.CreateMap<Entity6, EntityDTO6>().ReverseMap();
                cfg.CreateMap<Entity7, EntityDTO7>().ReverseMap();
                cfg.CreateMap<Entity8, EntityDTO8>().ReverseMap();
                cfg.CreateMap<Entity9, EntityDTO9>().ReverseMap();
                cfg.CreateMap<Entity10, EntityDTO10>().ReverseMap();
                cfg.CreateMap<Entity11, EntityDTO11>().ReverseMap();
                cfg.CreateMap<Entity12, EntityDTO12>().ReverseMap();
                cfg.CreateMap<Entity13, EntityDTO13>().ReverseMap();
                cfg.CreateMap<Entity14, EntityDTO14>().ReverseMap();
                cfg.CreateMap<Entity15, EntityDTO15>().ReverseMap();
                cfg.CreateMap<Entity16, EntityDTO16>().ReverseMap();
                cfg.CreateMap<Entity17, EntityDTO17>().ReverseMap();
                cfg.CreateMap<Entity18, EntityDTO18>().ReverseMap();
                cfg.CreateMap<Entity19, EntityDTO19>().ReverseMap();
                cfg.CreateMap<Entity20, EntityDTO20>().ReverseMap();
                cfg.CreateMap<Entity21, EntityDTO21>().ReverseMap();
                cfg.CreateMap<Entity22, EntityDTO22>().ReverseMap();
                cfg.CreateMap<Entity23, EntityDTO23>().ReverseMap();
                cfg.CreateMap<Entity24, EntityDTO24>().ReverseMap();
                cfg.CreateMap<Entity25, EntityDTO25>().ReverseMap();
                cfg.CreateMap<Entity26, EntityDTO26>().ReverseMap();
            });

            return config.CreateMapper();
        }
    }
}
