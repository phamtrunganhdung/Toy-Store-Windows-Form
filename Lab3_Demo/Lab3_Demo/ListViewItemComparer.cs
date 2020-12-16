using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;

namespace Lab3_Demo
{
    public class ListViewItemComparer: IComparer
    {
        private int column;
        private bool numeric = false;

        public int Column
        {

            get { return column; }
            set { column = value; }
        }

        public bool Numeric
        {

            get { return numeric; }
            set { numeric = value; }
        }

        public ListViewItemComparer(int columnIndex)
        {

            Column = columnIndex;
        }

        public int Compare(object x, object y)
        {

            ListViewItem listX = (ListViewItem)x;
            ListViewItem listY = (ListViewItem)y;

            if (Numeric)
            {

                // Convert column text to numbers before comparing.
                // If the conversion fails, just use the value 0.
                decimal listXVal, listYVal;
                try
                {
                    listXVal = Decimal.Parse(listX.SubItems[Column].Text);
                }
                catch
                {
                    listXVal = 0;
                }

                try
                {
                    listYVal = Decimal.Parse(listY.SubItems[Column].Text);
                }
                catch
                {
                    listYVal = 0;
                }

                return Decimal.Compare(listXVal, listYVal);
            }
            else
            {

                // Keep the column text in its native string format
                // and perform an alphabetic comparison.
                string listXText = listX.SubItems[Column].Text;
                string listYText = listY.SubItems[Column].Text;

                return String.Compare(listXText, listYText);
            }
        }
    }
}
