using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Model
{
    class ShopStorageGenerator
    {
        private IPCComponentsFactory factory;

        public void ChangeFactory(IPCComponentsFactory currentFactory)
        {
            factory = currentFactory;
        }
        public ShopStorageGenerator(IPCComponentsFactory currentFactory)
        {
            factory = currentFactory;
        }

        public void GenerateModelSeries(int count)
        {
            var storage = ShopStorage.getInstance();
            for (int i = 0; i < count; i++)
            {
                var CPU = factory.createCPU();
                storage.AddItem(CPU);
                var motherboard = factory.createMotherboard();
                storage.AddItem(motherboard);
                var memory = factory.createMemory();
                storage.AddItem(memory);
            }
        }
        public void GenerateModelSeries(int count, string product)
        {
            var storage = ShopStorage.getInstance();
            switch (product){
                case "CPU":
                    for (int i = 0; i < count; i++)
                    {
                        var CPU = factory.createCPU();
                        storage.AddItem(CPU);
                        
                    }
                    break;
                case "Motherboard":
                    for (int i = 0; i < count; i++)
                    {
                        var Motherboard = factory.createMotherboard();
                        storage.AddItem(Motherboard);

                    }
                    break;
                case "Memory":
                    for (int i = 0; i < count; i++)
                    {
                        var Memory = factory.createMemory();
                        storage.AddItem(Memory);

                    }
                    break;
            }

        }
        public void GenerateModelSeries(int cpu_count ,int mother_count, int memory_count)
        {
            var storage = ShopStorage.getInstance();
            for (int i = 0; i < cpu_count; i++)
            {
                var CPU = factory.createCPU();
                storage.AddItem(CPU);
                
            }
            for (int i = 0; i < mother_count; i++)
            {
                
                var motherboard = factory.createMotherboard();
                storage.AddItem(motherboard);
                
            }
            for (int i = 0; i < memory_count; i++)
            {
                
                var memory = factory.createMemory();
                storage.AddItem(memory);
            }
        }
    }
}
