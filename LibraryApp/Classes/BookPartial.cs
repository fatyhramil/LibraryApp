using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LibraryApp
{
    public partial class Book
    {
        public string FullImagePath
        {
            get
            {
                if (PhotoName != null)
                {
                    return "/Images/" + PhotoName;
                }
                else
                {
                    return "/Images/picture.png";
                }
                
            }
        }
        public SolidColorBrush DiscountColor
        {
            get
            {
                if (CurrentDiscount >= 15)
                {
                    return (SolidColorBrush)new BrushConverter().ConvertFrom("#7fff00");
                }
                else
                {
                    return Brushes.White;
                }
            }
        }
        public string FinalPrice
        {
            get
            {
                if (CurrentDiscount != 0 && CurrentDiscount != null)
                {
                    string price = Price.ToString()+"  ";
                
                    return price+(Price - ((decimal)(CurrentDiscount * 0.01) * Price)).ToString();
                }
                else
                {
                    return Price.ToString();
                }
            }
        }
        public Visibility LineVisibility
        {
            get
            {
                if (CurrentDiscount == null || CurrentDiscount == 0)
                {
                    return Visibility.Hidden;
                }
                else
                {
                    return Visibility.Visible;
                }
            }
        }
    }
}
