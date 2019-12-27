using Myvet.Web.Data.Entities;
using Myvet.Web.Models;
using System.Threading.Tasks;

namespace Myvet.Web.Helpers
{
    public interface IConverterHelper
    {
        Task<Pet> ToPetAsync(PetViewModel model, string path);
    }
}