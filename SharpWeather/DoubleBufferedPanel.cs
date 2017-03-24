/*
 * Created by SharpDevelop.
 * User: edenfield-john
 * Date: 12/29/2016
 * Time: 11:05 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace SharpWeather
{
	/// <summary>
	/// Description of DoubleBufferPanel.
	/// </summary>
	public class DoubleBufferedPanel : Panel
    {
        public DoubleBufferedPanel()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.UserPaint, true);
        }
    }
}
