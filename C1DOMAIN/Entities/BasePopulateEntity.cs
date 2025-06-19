namespace C1DOMAIN.Entities
{
    public class BasePopulateEntity
    {
        public BasePopulateEntity(string bValue, string bText)
        {
            BValue = bValue;
            BText = bText;
        }

        public string BValue { get; private set; } 
        public string BText { get; private set; }
    }
}
