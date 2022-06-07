using System;
using System.Collections;
using System.Windows.Forms;

namespace ToDoListXD
{
    // Implements the manual sorting of items by column.
    // Example usage:
    //      var lvcs = new ListViewColumnSorter();
    //      ListView.ListViewItemSorter = lvcs;
    //      lvcs.Order = SortOrder.Ascending;
    //      lvcs.SortColumn = 1; // Contains DateTime values in string format e.g, 12/12/2012
    //      ListView.Sort();
    public class ListViewColumnSorter : IComparer
    {
        public int ColumnToSort;
        public SortOrder OrderOfSort;

        public ListViewColumnSorter()
        {
            ColumnToSort = 0;
            OrderOfSort = SortOrder.None;
        }

        // Compare by datetime, put null dates at front
        public int Compare(object x, object y)
        {
            int returnVal;
            bool not_a_datetime = false;
            
            try      // Determine whether the type being compared is a date type.
            {
                System.DateTime firstDate = DateTime.Parse(((ListViewItem)x).SubItems[ColumnToSort].Text);
                System.DateTime secondDate = DateTime.Parse(((ListViewItem)y).SubItems[ColumnToSort].Text);
                returnVal = DateTime.Compare(firstDate, secondDate);
            }
            
            catch    // Always put null dates first in the list as they are daily/need doing asap
            {
                not_a_datetime = true;

                int x_length = ((ListViewItem)x).SubItems[ColumnToSort].Text.Length;
                int y_length = ((ListViewItem)y).SubItems[ColumnToSort].Text.Length;

                if (x_length == 0 && y_length >= 1)
                {
                    returnVal = -1;
                }
                else if (x_length >= 1 && y_length == 0)
                {
                    returnVal = 1;
                }
                else
                {
                    returnVal = 0;
                }
            }

            if (OrderOfSort == SortOrder.Descending && not_a_datetime == false)
            {
                returnVal *= -1;
            }

            return returnVal;
        }
    }
}
