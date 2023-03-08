
namespace Exchange.Web.Models
{
    public class GenericTableModel<T>
    {
        public List<Array> Columns { get; set; }
        public List<Array> Rows { get; set; }

        public static GenericTableModel<T> Table (List<Array>columns, List<Array>rows)
        {
            return new GenericTableModel<T> { Columns = columns, Rows = rows };
        }
    }
}
