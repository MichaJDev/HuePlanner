using HuePlanner.Logic.DTOS.Enums.Packaging;

namespace HuePlanner.Logic.DTOS.Consumables.Interface
{
    public interface IConsumable
    {
        public string GetName();

        public PackagingType GetType();

        public void SetName(string name);

        public void SetPackagingType(PackagingType type);
    }
}
