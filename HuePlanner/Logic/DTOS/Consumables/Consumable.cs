using HuePlanner.Logic.DTOS.Consumables.Interface;
using HuePlanner.Logic.DTOS.Enums.Packaging;

namespace HuePlanner.Logic.DTOS.Consumables
{
    public class Consumable : IConsumable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PackagingType Packaging {get;set;}

      
    }
}
