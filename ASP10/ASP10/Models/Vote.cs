using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP10.Models
{
    public class Vote
    {
        public IList<DataWork.Models.Article> Article = (IList<DataWork.Models.Article>) DataWork.WorkWithContext.GetSpliteArticles();
        public int[] Popular;
    }
}