using Microsoft.AspNetCore.Mvc.Rendering;
using Myvet.Web.Data;
using System.Collections.Generic;
using System.Linq;

namespace Myvet.Web.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _dataContex;

        public CombosHelper(DataContext dataContex)
        {
            _dataContex = dataContex;
        }

        public IEnumerable<SelectListItem> GetComboPetTypes()
        {
            //var list = new List<SelectListItem>();

            var list = _dataContex.PetTypes.Select(pt => new SelectListItem
            {
                Text = pt.Name,
                Value = $"{pt.Id}"
            })
                .OrderBy(pt => pt.Text)
                .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Select a pet type...]",
                Value = "0"
            });

            return list;
        }
    }
}
