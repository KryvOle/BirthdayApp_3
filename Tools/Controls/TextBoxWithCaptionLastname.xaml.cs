using System.Windows;
using System.Windows.Controls;

namespace BirthdayApp.Tools.Controls
{
    /// <summary>
    /// Логика взаимодействия для TextBoxWithCaptionLastname.xaml
    /// </summary>
    public partial class TextBoxWithCaptionLastname : UserControl
    {
        public string CaptionLastname
        {
            get
            {
                return TbCaptionLastname.Text;
            }
            set
            {
                TbCaptionLastname.Text = value;
            }
        }

        public string Text
        {
            get
            {
                return (string)GetValue(TextProperty);
            }
            set
            {
                SetValue(TextProperty, value);
            }
        }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register
            (
            "Text",
            typeof(string),
            typeof(TextBoxWithCaptionLastname),
            new PropertyMetadata(null)
            );

        public TextBoxWithCaptionLastname()
        {
            InitializeComponent();
        }
    }
}
