using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Registration
{
    public static class FormPositionHandler
    {
        /// <summary>
        /// Sets the location of the sent Form just next to caller form, The priority is Left, then Bottom, Right and Top in
        /// that order. If no space is found for the 4 options then the defualt position will be set.
        /// </summary>
        /// <param name="callerForm">Calling Form</param>
        /// <param name="formToShow">Form to position next to caller.</param>
        /// <param name="autoShow">Auto execute Form.Show() at the end of the Method.</param>
        public static void ShowFormNext(this Form callerForm, Form formToShow, bool autoShow = true)
        {
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;

            Point parentPoint = callerForm.Location;

            int parentHeight = callerForm.Height;
            int parentWidth = callerForm.Width;

            int childHeight = formToShow.Height;
            int childWidth = formToShow.Width;

            int resultX = 0;
            int resultY = 0;
            bool isSpaceBottom = (parentPoint.Y + parentHeight + childHeight) < screenHeight;
            bool isSpaceRight  = (parentPoint.X + parentWidth + childWidth) < screenWidth;
            bool isSpaceLeft   = (parentPoint.X - childWidth) > 0;
            bool isSpaceTop    = (parentPoint.Y - childHeight) > 0;
            if (isSpaceRight)
            {
                resultX = parentPoint.X + parentWidth;
                resultY = parentPoint.Y;
            }
            else if (isSpaceBottom)
            {
                resultX = parentPoint.X;
                resultY = parentPoint.Y + parentHeight;
            }
            else if (isSpaceLeft)
            {
                resultX = parentPoint.X;
                resultY = parentPoint.Y - childHeight;
            }
            else if (isSpaceTop)
            {
                resultX = parentPoint.X - childWidth;
                resultY = parentPoint.Y;
            }

            // set our child form to the new position
            if (isSpaceBottom || isSpaceRight || isSpaceLeft || isSpaceTop)
            {
                formToShow.Location = new Point(resultX, resultY);
                formToShow.StartPosition = FormStartPosition.Manual;
            }
            else
                formToShow.StartPosition = FormStartPosition.WindowsDefaultLocation;

            if (autoShow)
                formToShow.Show();
        }
    }
}