using Business.Interfaces.Infra;
using ExcelDataReader;

namespace OfficeFile
{
    public class ExcelFile : IExcelFile
    {
        public List<List<object>> Open(string filePath)
        {
            var excelData = new List<List<object>>();

            using (var stream = System.IO.File.Open(filePath, FileMode.Open, FileAccess.Read))
            {

                using (var reader = ExcelReaderFactory.CreateReader(stream, new ExcelReaderConfiguration()
                {
                    //FallbackEncoding = Encoding.GetEncoding(1252)
                }))
                {

                    List<string> excel = new List<string>();
                    // 1. Use the reader methods
                    do
                    {
                        while (reader.Read())
                        {
                            var rowData = new List<object>();
                            for (int column = 0; column < reader.FieldCount; column++)
                            {
                                rowData.Add(reader.GetValue(column));
                            }
                            excelData.Add(rowData);


                        }
                    } while (reader.NextResult());
                }
            }
            return excelData;
        }

    }
}
