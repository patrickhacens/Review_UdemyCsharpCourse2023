namespace _07_NET_UnderTheHood.NewSolution
{
    public class FastRow
    {
        private Dictionary<string, bool> _BoolData = new();
        private Dictionary<string, int> _IntData = new();
        private Dictionary<string, decimal> _DeciamlData = new();
        private Dictionary<string, string> _StringData = new();


        public FastRow()
        {
        }

        public void AssingCell(string columnName, bool value)
        {
            _BoolData[columnName] = value;
        }
        public void AssingCell(string columnName, int value)
        {
            _IntData[columnName] = value;
        }
        public void AssingCell(string columnName, decimal value)
        {
            _DeciamlData[columnName] = value;
        }
        public void AssingCell(string columnName, string value)
        {
            _StringData[columnName] = value;
        }


        public object? GetAtColumn(string columnName)
        {
            if (_BoolData.ContainsKey(columnName))
            {
                return _BoolData[columnName];
            }
            else if (_IntData.ContainsKey(columnName))
            {
                return _IntData[columnName];
            }
            else if (_DeciamlData.ContainsKey(columnName))
            {
                return _DeciamlData[columnName];
            }
            else if (_StringData.ContainsKey(columnName))
            {
                return _StringData[columnName];
            }

            return null;
        }
    }
}
