using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace bugTouchBehavior
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Person> Persons { get; set; } = [];
        public DebugObservableCollection<object> SelectedPersons { get; set; } = [];

        public MainPage()
        {
            this.BindingContext = this;

            InitializeComponent();

            for (int i = 0; i < 5; ++i) 
                Persons.Add(new(i));

            CmdTouch = new Command<object?>(DoTouch);
    }

        public Command<object?> CmdTouch { get; }


        void DoTouch(object? obj)
        {
            if(obj is Person p) 
                Console.WriteLine(p.Id);
        }
    }

    public record Person(int Id);
}
