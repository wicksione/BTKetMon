using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public partial class NCKHSinhVien : Component
    {
        public NCKHSinhVien()
        {
            InitializeComponent();
        }

        public NCKHSinhVien(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
