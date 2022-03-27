using HuePlanner.Logic.DTOS.Enums.Packaging;

namespace HuePlanner.Logic.DTOS.Consumables.Interface
{
    public interface IConsumable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PackagingType Packaging { get; set; }
    }
}
