using System.Windows;
using System.Windows.Controls;

namespace BirthdayApp.Tools.Controls
{
    /// <summary>
    /// Логика взаимодействия для TextBoxWithCaptionFirstname.xaml
    /// </summary>
    public partial class TextBoxWithCaptionFirstname : UserControl
    {
        public string CaptionFirstname
        {
            get
            {
                return TbCaptionFirstname.Text;
            }
            set
            {
                TbCaptionFirstname.Text = value;
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
            typeof(TextBoxWithCaptionFirstname),
            new PropertyMetadata(null)
            );

        public TextBoxWithCaptionFirstname()
        {
            InitializeComponent();
        }
    }
}
