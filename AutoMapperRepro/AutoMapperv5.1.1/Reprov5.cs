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
            //2 elements in a list
            Map(2);
            Map(2);
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
            //List of objects performing slow
            //Entity1
            //Entity17
            //Entity25
            //Entity19
            //Entity15
            //Entity13
            //Entity7
            //Entity5
            //Entity2

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
                cfg.CreateMap<Entity1, EntityDTO1>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity2, EntityDTO2>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity3, EntityDTO3>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity4, EntityDTO4>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity5, EntityDTO5>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity6, EntityDTO6>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity7, EntityDTO7>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity8, EntityDTO8>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity9, EntityDTO9>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity10, EntityDTO10>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity11, EntityDTO11>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity12, EntityDTO12>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity13, EntityDTO13>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity14, EntityDTO14>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity15, EntityDTO15>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity16, EntityDTO16>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity17, EntityDTO17>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity18, EntityDTO18>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity19, EntityDTO19>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity20, EntityDTO20>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity21, EntityDTO21>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity22, EntityDTO22>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity23, EntityDTO23>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity24, EntityDTO24>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity25, EntityDTO25>().PreserveReferences().ReverseMap().PreserveReferences();
                cfg.CreateMap<Entity26, EntityDTO26>().PreserveReferences().ReverseMap().PreserveReferences();
            });

            return config.CreateMapper();
        }
    }
}
