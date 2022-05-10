using System.Windows;
using System.Windows.Controls;


namespace BirthdayApp.Tools.Controls
{
    /// <summary>
    /// Логика взаимодействия для TextBoxWithCaptionEmail.xaml
    /// </summary>
    public partial class TextBoxWithCaptionEmail : UserControl
    {
        public string CaptionEmail
        {
            get
            {
                return TbCaptionEmail.Text;
            }
            set
            {
                TbCaptionEmail.Text = value;
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
            typeof(TextBoxWithCaptionEmail),
            new PropertyMetadata(null)
            );

        public TextBoxWithCaptionEmail()
        {
            InitializeComponent();
        }
    }
}
