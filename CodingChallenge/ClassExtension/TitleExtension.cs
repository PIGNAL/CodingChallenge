namespace CodingChallenge.ClassExtension
{
    public static class TitleExtension
    {
        public static ViewModels.TitleViewModel ConvertToViewModel(this DataAccess.Title title)
        {
            var titleViewModel = new ViewModels.TitleViewModel
            {
                TitleId = title.TitleId,
                Name = title.Name,
                Symbol = title.Symbol,
                Last = title.Last,
                VarPer = title.Var_,
                CapMarket = title.CapMarket,
                Volume = title.Volume
            };
            return titleViewModel;
        }

    }
}