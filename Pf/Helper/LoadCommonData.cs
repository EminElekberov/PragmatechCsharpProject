using Pf.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pf.Helper
{
    public static class LoadCommonData
    {
        public static ParfumEntities1 parfumEntities = new ParfumEntities1();
        public static void LoadCategory(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            var categorys = LoadCommonData.parfumEntities.Categories.Select(dr => dr.Name);
            if (categorys != null)
            {
                foreach (var item in categorys)
                {
                    comboBox.Items.Add(item);
                }
            }
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.SelectedIndex = 0;
        }
    }
}
