namespace _07_NET_UnderTheHood.NewSolution
{
    public class FastRow
    {
        private Dictionary<string, object> _data;

        public FastRow(Dictionary<string, object> data)
        {
            _data = data;
        }

        public object GetAtColumn(string columnName)
        {
            return _data.GetValueOrDefault(columnName, null);
        }
    }
}
