using CodingChallenge.Data.DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.BusinessLogic
{
    public class TitleHandler
    {
        MockRepository repo = new MockRepository();
        public List<Data.Classes.Titulo> GetTitles()
        {
            return repo.TituloRepository.GetTitulos().ToList();
        }
        public Data.Classes.Titulo Search(int id)
        {
            return repo.TituloRepository.GetTitulos().FirstOrDefault(x => x.Id == id);
        }
    }
}
