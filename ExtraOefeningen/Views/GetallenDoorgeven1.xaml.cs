using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraOefeningen.Views;

public partial class GetallenDoorgeven1 : ContentPage
{
    public GetallenDoorgeven1(GetallenDoorgeven1ViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}