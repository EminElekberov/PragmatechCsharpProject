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
        public static void LoadSearchName(ComboBox combSearchName)
        {

            // ComboBox Index
            int comboxIndex = 0;

            // Data Clear
            combSearchName.DataSource = null;

            // Collection Create
            List<ParfumHeader> parfumHeaders = new List<ParfumHeader>();

            // Collection Clear
            parfumHeaders.Clear();


            var searchHeader = parfumEntities.SearchHeads.OrderBy(dr => dr.Header).ToList();

            foreach (var item in searchHeader)
            {
                // Collection add
                parfumHeaders.Add(new ParfumHeader(item.Id, item.Header, comboxIndex));
                ++comboxIndex;
            }


            // Data Add
            combSearchName.DataSource = parfumHeaders;
            combSearchName.DropDownStyle = ComboBoxStyle.DropDownList;
            combSearchName.SelectedIndex = 0;

        }

    }
}
