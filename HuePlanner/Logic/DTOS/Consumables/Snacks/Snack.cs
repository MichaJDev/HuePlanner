using HuePlanner.Logic.DTOS.Consumables.Snacks.Interface;

namespace HuePlanner.Logic.DTOS.Consumables.Snacks
{
    public class Snack : Consumable, ISnack
    {
        private int content;

        public int GetContent()
        {
            return content;
        }

        public void SetContent(int _content)
        {
            content = _content;
        }
    }
}
