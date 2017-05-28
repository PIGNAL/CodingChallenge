using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.DataAccess
{
    public interface ITitleRepository
    {
        List<Title> ToList();
        Title Search(int id);
    }
    public class TitleRepository : ITitleRepository
    {
        CodingChallengeEntities model = new CodingChallengeEntities();
        public List<Title> ToList()
        {
            return model.Title.ToList();
        }
        public Title Search(int id)
        {
            return model.Title.Where(x => x.TitleId == id).FirstOrDefault();
        }
    }
}
