namespace Aula01_MVC.Repository
{
    public interface IPeopleRepository
    {
        string GetNameById(int id); 
    }
    public class PeopleRepository : IPeopleRepository
    {
        public PeopleRepository(string connectionString){
            
        }

        public string GetNameById(int id)
        {
            return "Jusé da Silva";
        }
    }
}