using JETech.Leasing.Web.Data.Entities;
using JETech.Leasing.Web.Models;
using System.Threading.Tasks;

namespace MyLeasing.Web.Helpers
{
    public interface IConverterHelper
    {
        Task<Contract> ToContractAsync(ContractViewModel model, bool isNew);
        ContractViewModel ToContractViewModel(Contract contract);
        Task<Property> ToPropertyAsync(PropertyViewModel model, bool isNew);
        PropertyViewModel ToPropertyViewModel(Property property);
    }
}