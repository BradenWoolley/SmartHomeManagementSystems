using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace SEN381
{
    public partial class TechSupport : UserControl, IBinding, IValidate
    {
        public TechSupport()
        {
            InitializeComponent();
        }

        

        public void RefreshActors()
        {
            //throw new NotImplementedException();
        }

        public void RefreshAll()
        {
            //throw new NotImplementedException();
        }

        public void RefreshComponents()
        {
            //throw new NotImplementedException();
        }

        public void RefreshControllers()
        {
            //throw new NotImplementedException();
        }

        public void RefreshSensors()
        {
            //throw new NotImplementedException();
        }

        public bool IsInRange(ComboBox combo)
        {
            //throw new NotImplementedException();
            return true;
        }

        public bool IsNullOrWhiteSpace(List<MaterialSingleLineTextField> fields)
        {
            //throw new NotImplementedException();
            return false;
        }

        public bool IsNumeric(List<MaterialSingleLineTextField> fields)
        {
            //throw new NotImplementedException();
            return true;
        }
    }
}
