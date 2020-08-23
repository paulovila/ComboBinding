using System.Collections.Generic; 
using System.Threading;
using System.Linq;
namespace ComboBinding
{
    public sealed partial class MainPage 
    {
        public MainPage()
        {
            InitializeComponent();
            _ = new EViewModel();
        }
        public EViewModel _ { get; }

    }

    public class EViewModel
    {
        public EViewModel()
        {
            ResumeOption = ResumeOptions.First().Option;

        }
        public List<OptionT<int>> ResumeOptions { get; } = new List<OptionT<int>>(new[]
        {
            new OptionT<int> {Text = "Disable resume", Option = Timeout.Infinite},
            new OptionT<int> {Text = "Resume after 5 secs", Option = 5},
            new OptionT<int> {Text = "Resume after 10 secs", Option = 10}
        });

        public int? ResumeOption
        {
            get;
            set;
        }
    }
    public class OptionT<T>
    {
        public virtual string Text { get; set; }
        public T Option { get; set; }
    }
}
