using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381
{
    interface IValidate
    {
        bool IsNullOrWhiteSpace(List<MaterialSingleLineTextField> fields);

        bool IsNumeric(List<MaterialSingleLineTextField> fields);

    }
}
