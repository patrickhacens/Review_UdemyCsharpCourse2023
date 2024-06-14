using System.Reflection;

public class UniversalTablePrinter
{

    public UniversalTablePrinter(IEnumerable<object> data)
    {
        object firstElement = data.First();
        if (firstElement is not null)
        {
            Type type = firstElement.GetType();
            PropertyInfo[] props = type.GetProperties();

            //print table columns name
            foreach (PropertyInfo prop in props)
            {
                Console.WriteLine($"{prop.Name}-10");
            }

        }




        //print the data

        //foreach (var item in data)
        //{
        //    //item.
        //}


    }
}