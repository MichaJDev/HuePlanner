using HuePlanner.Logic.DTOS.Consumables.Interface;
using HuePlanner.Logic.DTOS.Enums.Packaging;

namespace HuePlanner.Logic.DTOS.Consumables
{
    public class Consumable : IConsumable
    {
        private string name = "";
        private PackagingType packaging;

        public string GetName()
        {
            return name;
        }

        public void SetName(string _name)
        {
            name = _name;
        }

        public void SetPackagingType(PackagingType _packaging)
        {
            packaging = _packaging;
        }

        PackagingType IConsumable.GetType()
        {
            return packaging;
        }
    }
}
