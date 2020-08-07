using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace JETech.Leasing.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboLessees();
        IEnumerable<SelectListItem> GetComboPropertyTypes();
        IEnumerable<SelectListItem> GetComboRoles();
    }
}