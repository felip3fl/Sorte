namespace Business.Interfaces.Infra
{
    public interface IExcelFile
    {
        List<List<object>> Open(string filePath);
    }
}
