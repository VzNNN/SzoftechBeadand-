using WhereIsMyMoney.ViewModel;

namespace WhereIsMyMoney.Models
{
    public class MoneyDTO : BaseViewModel
    {
        public int Value { get; set; }
        public string Type { get; set; }
        public int Duration { get; set; }
        public int Total { get; set; }
    }
}
