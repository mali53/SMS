using System.Drawing;
using System.Windows.Forms;

public class IconTextBox : TextBox
{
    private Image icon;

    public Image Icon
    {
        get { return icon; }
        set
        {
            icon = value;
            Invalidate();
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        if (icon != null)
        {
            // Draw the icon to the left of the text box
            int iconWidth = icon.Width;
            int iconHeight = icon.Height;
            int iconX = 2; // Adjust this value to set the left margin for the icon
            int iconY = (Height - iconHeight) / 2;

            e.Graphics.DrawImage(icon, iconX, iconY, iconWidth, iconHeight);
        }
    }
}
