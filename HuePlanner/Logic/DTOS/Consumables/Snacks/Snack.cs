using HuePlanner.Logic.DTOS.Consumables.Snacks.Interface;

namespace HuePlanner.Logic.DTOS.Consumables.Snacks
{
    public class Snack : Consumable, ISnack
    {
        public int Amount { get; set; }


    }
}
