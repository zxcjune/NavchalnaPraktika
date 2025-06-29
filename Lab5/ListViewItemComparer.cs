using System.Collections;
using System.Windows.Forms;

namespace Lab5
{
    public class ListViewItemComparer : IComparer
    {
        private int _col;
        private SortOrder _order;

        public ListViewItemComparer()
        {
           _col = 0;
           _order = SortOrder.Ascending;
        }

        public ListViewItemComparer(int col, SortOrder order)
        {
            _col = col;
            this._order = order;
        }

        public int Compare(object x, object y)
        {
            int returnVal;

            if (int.TryParse(((ListViewItem)x).SubItems[_col].Text, out int numX) &&
            int.TryParse(((ListViewItem)y).SubItems[_col].Text, out int numY))
            {
                returnVal = numX.CompareTo(numY);
            }
            else
            {
                returnVal = string.Compare(((ListViewItem)x).SubItems[_col].Text,
                                           ((ListViewItem)y).SubItems[_col].Text);
            }

            if (_order == SortOrder.Descending) 
            {
                returnVal *= -1;
            }

            return returnVal;
        }
    }
}
