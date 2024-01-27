namespace Homeworks.MiniBank
{
    public class Client : Person // მემკვიდრეობა
    {
        public Account Account { get; set; } // კომპოზიცია Navigation Property

        //public override string ToString()
        //{
        //    return $"{Account.Balance}";
        //}
    }
}
