using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using course_work_3_0.connect;
using course_work_3_0.model;

namespace course_work_3_0.classes
{
    public static class cmbClass
    {
        public static void LoadType(ComboBox combobox)
        {
            var query = dbConnnect.db.GROUP.Select(item => new
            {
                titleItem = item.TITLE
            });
            var collectionType = from selectedItem in query select selectedItem.titleItem;
            combobox.ItemsSource = collectionType.ToList();
        }
    }
}
