using CodingChallenge.DataAccess;
using System.Collections.Generic;

namespace CodingChallenge.BusinessLogic
{
    public class TitleHandler
    {
        public ITitleRepository _repo;
        public TitleHandler(ITitleRepository repo)
        {
            _repo = repo;
        }
        public List<Title> ToList()
        {
            return _repo.ToList();
        }
        public Title Search(int id)
        {
            return _repo.Search(id);
        }
    }
}
